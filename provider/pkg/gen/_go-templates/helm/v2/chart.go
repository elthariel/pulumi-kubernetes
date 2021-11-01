// Copyright 2016-2021, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package helm

import (
	"bytes"
	"encoding/json"
	"fmt"
	"io/ioutil"
	"os"
	"os/exec"
	"path/filepath"
	"regexp"
	"sort"
	"strings"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/yaml"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Chart is a component representing a collection of resources described by an arbitrary Helm
// Chart. The Chart can be fetched from any source that is accessible to the `helm` command
// line. Values in the `values.yml` file can be overridden using `ChartOpts.values` (equivalent
// to `--set` or having multiple `values.yml` files). Objects can be transformed arbitrarily by
// supplying callbacks to `ChartOpts.transformations`.
//
// `Chart` does not use Tiller. The Chart specified is copied and expanded locally; the semantics
// are equivalent to running `helm template` and then using Pulumi to manage the resulting YAML
// manifests. Any values that would be retrieved in-cluster are assigned fake values, and
// none of Tiller's server-side validity testing is executed.
//
// ## Example Usage
// ### Local Chart Directory
//
// ```go
// package main
//
// import (
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v3"
//     "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
//     pulumi.Run(func(ctx *pulumi.Context) error {
//         _, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
//             Path: pulumi.String("./nginx-ingress"),
//         })
//         if err != nil {
//             return err
//         }
//
//         return nil
//     })
// }
// ```
// ### Remote Chart
//
// ```go
// package main
//
// import (
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v3"
//     "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
//     pulumi.Run(func(ctx *pulumi.Context) error {
//         _, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
//             Chart:   pulumi.String("nginx-ingress"),
//             Version: pulumi.String("1.24.4"),
//             FetchArgs: helm.FetchArgs{
//                 Repo: pulumi.String("https://charts.helm.sh/stable"),
//             },
//         })
//         if err != nil {
//             return err
//         }
//
//         return nil
//     })
// }
// ```
// ### Set Chart values
//
// ```go
// package main
//
// import (
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v3"
//     "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
//     pulumi.Run(func(ctx *pulumi.Context) error {
//         _, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
//             Chart:   pulumi.String("nginx-ingress"),
//             Version: pulumi.String("1.24.4"),
//             FetchArgs: helm.FetchArgs{
//                 Repo: pulumi.String("https://charts.helm.sh/stable"),
//             },
//             Values: pulumi.Map{
//                 "controller": pulumi.Map{
//                     "metrics": pulumi.Map{
//                         "enabled": pulumi.Bool(true),
//                     },
//                 },
//             },
//         })
//         if err != nil {
//             return err
//         }
//
//         return nil
//     })
// }
// ```
// ### Deploy Chart into Namespace
//
// ```go
// package main
//
// import (
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v3"
//     "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
//     pulumi.Run(func(ctx *pulumi.Context) error {
//         _, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
//             Chart:     pulumi.String("nginx-ingress"),
//             Version:   pulumi.String("1.24.4"),
//             Namespace: pulumi.String("test-namespace"),
//             FetchArgs: helm.FetchArgs{
//                 Repo: pulumi.String("https://charts.helm.sh/stable"),
//             },
//         })
//         if err != nil {
//             return err
//         }
//
//         return nil
//     })
// }
// ```
// ### Chart with Transformations
//
// ```go
// package main
//
// import (
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v3"
//     "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/yaml"
//     "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
//     pulumi.Run(func(ctx *pulumi.Context) error {
//         _, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
//             Chart:   pulumi.String("nginx-ingress"),
//             Version: pulumi.String("1.24.4"),
//             FetchArgs: helm.FetchArgs{
//                 Repo: pulumi.String("https://charts.helm.sh/stable"),
//             },
//             Transformations: []yaml.Transformation{
//                 // Make every service private to the cluster, i.e., turn all services into ClusterIP
//                 // instead of LoadBalancer.
//                 func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
//                     if state["kind"] == "Service" {
//                         spec := state["spec"].(map[string]interface{})
//                         spec["type"] = "ClusterIP"
//                     }
//                 },
//
//                 // Set a resource alias for a previous name.
//                 func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
//                     if state["kind"] == "Deployment" {
//                         aliases := pulumi.Aliases([]pulumi.Alias{
//                             {
//                                 Name: pulumi.String("oldName"),
//                             },
//                         })
//                         opts = append(opts, aliases)
//                     }
//                 },
//
//                 // Omit a resource from the Chart by transforming the specified resource definition
//                 // to an empty List.
//                 func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
//                     name := state["metadata"].(map[string]interface{})["name"]
//                     if state["kind"] == "Pod" && name == "test" {
//                         state["apiVersion"] = "core/v1"
//                         state["kind"] = "List"
//                     }
//                 },
//             },
//         })
//         if err != nil {
//             return err
//         }
//
//         return nil
//     })
// }
// ```
type Chart struct {
	pulumi.ResourceState

	Ready     pulumi.ResourceArrayOutput
	Resources pulumi.Output
}

// NewChart registers a new resource with the given unique name, arguments, and options.
func NewChart(ctx *pulumi.Context,
	name string, args ChartArgs, opts ...pulumi.ResourceOption) (*Chart, error) {

	// Register the resulting resource state.
	chart := &Chart{}
	err := ctx.RegisterComponentResource("kubernetes:helm.sh/v2:Chart", name, chart, opts...)
	if err != nil {
		return nil, err
	}

	// Honor the resource name prefix if specified.
	if args.ResourcePrefix != "" {
		name = args.ResourcePrefix + "-" + name
	}

	resources := args.ToChartArgsOutput().ApplyT(func(args chartArgs) (map[string]pulumi.Resource, error) {
		return parseChart(ctx, name, args, pulumi.Parent(chart))
	})
	chart.Resources = resources

	// Finally, register all of the resources found.
	// Note: Go requires that we "pull" on our futures in order to get them scheduled for execution. Here, we use
	// the engine's RegisterResourceOutputs to wait for the resolution of all resources that this Helm chart created.
	err = ctx.RegisterResourceOutputs(chart, pulumi.Map{"resources": resources})
	if err != nil {
		return nil, errors.Wrap(err, "registering child resources")
	}

	chart.Ready = resources.ApplyT(func(x interface{}) []pulumi.Resource {
		resources := x.(map[string]pulumi.Resource)
		var outputs []pulumi.Resource
		for _, r := range resources {
			outputs = append(outputs, r)
		}
		return outputs
	}).(pulumi.ResourceArrayOutput)

	return chart, nil
}

func parseChart(ctx *pulumi.Context, name string, args chartArgs, opts ...pulumi.ResourceOption,
) (map[string]pulumi.Resource, error) {

	// Create temporary directory and file to hold chart data and override values.
	chartDir, err := ioutil.TempDir("", "")
	if err != nil {
		return nil, errors.Wrap(err, "creating temp directory for chart")
	}
	defer os.RemoveAll(chartDir)
	overrides, err := ioutil.TempFile("", "values.*.yaml")
	if err != nil {
		return nil, errors.Wrap(err, "creating temp file for chart values")
	}
	defer os.Remove(overrides.Name())

	var chart string
	if args.Path != "" { // Local Chart
		chart = args.Path
	} else { // Remote Chart
		if strings.HasPrefix(args.Repo, "http") {
			return nil, fmt.Errorf("`repo` specifies the name of the Helm chart repo. Use FetchArgs.Repo" +
				"to specify a URL")
		}

		chartToFetch := args.Chart
		if len(args.Repo) > 0 {
			chartToFetch = fmt.Sprintf("%s/%s", args.Repo, chartToFetch)
		}

		// Fetch the Chart.
		if len(args.FetchArgs.Destination) == 0 {
			args.FetchArgs.Destination = chartDir
		}
		if len(args.FetchArgs.Version) == 0 {
			args.FetchArgs.Version = args.Version
		}
		err = fetch(chartToFetch, args.FetchArgs)
		if err != nil {
			return nil, err
		}

		// Get the path to the fetched Chart.
		files, err := ioutil.ReadDir(chartDir)
		if err != nil {
			return nil, errors.Wrap(err, "failed to read chart directory")
		}
		if len(files) == 0 {
			return nil, errors.New("chart directory was empty")
		}
		sort.Slice(files, func(i, j int) bool {
			return files[i].Name() < files[j].Name()
		})
		fetchedChartName := files[0].Name()

		chart = filepath.Join(chartDir, fetchedChartName)
	}

	defaultVals := filepath.Join(chart, "values.yaml")

	helmArgs := []string{"template", chart, "--name-template", name, "--values", defaultVals}
	// Write overrides file if Values set.
	if args.Values != nil {
		b, err := json.Marshal(args.Values)
		if err != nil {
			return nil, errors.Wrap(err, "failed to marshal overrides file")
		}
		_, err = overrides.Write(b)
		if err != nil {
			return nil, errors.Wrap(err, "failed to write overrides file")
		}
		helmArgs = append(helmArgs, "--values", overrides.Name())
	}
	if len(args.Namespace) > 0 {
		helmArgs = append(helmArgs, "--namespace", args.Namespace)
	}

	for _, version := range args.APIVersions {
		helmArgs = append(helmArgs, fmt.Sprintf("--api-versions=%s", version))
	}

	// Check for helm version
	v3, err := isHelmV3()

	if err != nil {
		return nil, err
	}

	if v3 {
		helmArgs = append(helmArgs, "--include-crds")
	}

	helmCmd := exec.Command("helm", helmArgs...)
	var stderr bytes.Buffer
	helmCmd.Stderr = &stderr
	yamlBytes, err := helmCmd.Output()
	if err != nil {
		return nil, errors.Wrap(err, fmt.Sprintf("failed to run helm template: %s", stderr.String()))
	}
	objs, err := yamlDecode(ctx, string(yamlBytes), args.Namespace)
	if err != nil {
		return nil, err
	}

	resources, err := yaml.ParseYamlObjects(ctx, objs, args.Transformations, args.ResourcePrefix, opts...)
	if err != nil {
		return nil, err
	}
	return resources, nil
}

// yamlDecode invokes the function to decode a single YAML file and decompose it into object structures.
func yamlDecode(ctx *pulumi.Context, text, namespace string) ([]map[string]interface{}, error) {
	args := struct {
		Text             string `pulumi:"text"`
		DefaultNamespace string `pulumi:"defaultNamespace"`
	}{Text: text, DefaultNamespace: namespace}
	var ret struct {
		Result []map[string]interface{} `pulumi:"result"`
	}
	if err := ctx.Invoke("kubernetes:yaml:decode", &args, &ret); err != nil {
		return nil, errors.Wrap(err, "failed to decode YAML")
	}
	return ret.Result, nil
}

func isHelmV3() (bool, error) {

	/*
		Helm v2 returns version like this:
		Client: v2.16.7+g5f2584f
		Helm v3 returns a version like this:
		v3.1.2+gd878d4d
		--include-crds is available in helm v3.1+ so check for a regex matching that version
	*/
	helmVerArgs := []string{"version", "--short"}
	helmVerCmd := exec.Command("helm", helmVerArgs...)

	var stderr bytes.Buffer
	helmVerCmd.Stderr = &stderr

	version, err := helmVerCmd.Output()
	if err != nil {
		return false, errors.Wrap(err, fmt.Sprintf("failed to check helm version: %s", stderr.String()))
	}

	matched, err := regexp.MatchString(`^v3\.[1-9]`, string(version))
	if err != nil {
		return false, errors.Wrap(err, fmt.Sprintf("failed to perform regex match: %s", stderr.String()))
	}

	return matched, nil

}

func fetch(name string, args fetchArgs) error {
	helmArgs := []string{"fetch", name}

	// Untar by default.
	if args.Untar == nil || !*args.Untar {
		helmArgs = append(helmArgs, "--untar")
	}

	env := os.Environ()
	// Helm v3 removed the `--home` flag, so we must use an env var instead.
	if len(args.Home) > 0 {
		found := false
		for i, v := range env {
			if strings.HasPrefix(v, "HELM_HOME=") {
				env[i] = fmt.Sprintf("HELM_HOME=%s", args.Home)
				found = true
				break
			}
		}
		if !found {
			env = append(env, fmt.Sprintf("HELM_HOME=%s", args.Home))
		}
	}

	if len(args.Version) > 0 {
		helmArgs = append(helmArgs, "--version", args.Version)
	}
	if len(args.CAFile) > 0 {
		helmArgs = append(helmArgs, "--ca-file", args.CAFile)
	}
	if len(args.CertFile) > 0 {
		helmArgs = append(helmArgs, "--cert-file", args.CertFile)
	}
	if len(args.KeyFile) > 0 {
		helmArgs = append(helmArgs, "--key-file", args.KeyFile)
	}
	if len(args.Destination) > 0 {
		helmArgs = append(helmArgs, "--destination", args.Destination)
	}
	if len(args.Keyring) > 0 {
		helmArgs = append(helmArgs, "--keyring", args.Keyring)
	}
	if len(args.Password) > 0 {
		helmArgs = append(helmArgs, "--password", args.Password)
	}
	if len(args.Repo) > 0 {
		helmArgs = append(helmArgs, "--repo", args.Repo)
	}
	if len(args.UntarDir) > 0 {
		helmArgs = append(helmArgs, "--untardir", args.UntarDir)
	}
	if len(args.Username) > 0 {
		helmArgs = append(helmArgs, "--username", args.Username)
	}
	if args.Devel != nil && *args.Devel {
		helmArgs = append(helmArgs, "--devel")
	}
	if args.Prov != nil && *args.Prov {
		helmArgs = append(helmArgs, "--prov")
	}
	if args.Verify != nil && *args.Verify {
		helmArgs = append(helmArgs, "--verify")
	}

	helmCmd := exec.Command("helm", helmArgs...)
	var stderr bytes.Buffer
	helmCmd.Stderr = &stderr
	err := helmCmd.Run()
	if err != nil {
		return errors.Wrap(err, fmt.Sprintf("failed to fetch Helm chart: %s", stderr.String()))
	}

	return nil
}

// GetResource returns a resource defined by a built-in Kubernetes group/version/kind, name and namespace.
// For example, GetResource("v1/Pod", "foo", "") would return a Pod called "foo" from the "default" namespace.
func (c *Chart) GetResource(gvk, name, namespace string) pulumi.AnyOutput {
	id := name
	if len(namespace) > 0 && namespace != "default" {
		id = fmt.Sprintf("%s/%s", namespace, name)
	}
	key := fmt.Sprintf("%s::%s", gvk, id)
	return c.Resources.ApplyT(func(x interface{}) interface{} {
		resources := x.(map[string]pulumi.Resource)
		return resources[key]
	}).(pulumi.AnyOutput)
}
