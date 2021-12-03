Chart is a component representing a collection of resources described by an arbitrary Helm Chart.

The Chart can be fetched from any source that is accessible to the `helm` command line. Values in the `values.yml` file can be overridden using `ChartOpts.values` (equivalent to `--set` or having multiple `values.yml` files). Objects can be transformed arbitrarily by supplying callbacks to `ChartOpts.transformations`.

`Chart` does not use Tiller. The Chart specified is copied and expanded locally; the semantics are equivalent to running `helm template` and then using Pulumi to manage the resulting YAML manifests. Any values that would be retrieved in-cluster are assigned fake values, and none of Tiller's server-side validity testing is executed.

{{% examples %}}
## Example Usage
{{% example %}}
### Local Chart Directory

```typescript
import * as k8s from "@pulumi/kubernetes";

const nginxIngress = new k8s.helm.v2.Chart("nginx-ingress", {
    path: "./nginx-ingress",
});
```
```python
from pulumi_kubernetes.helm.v2 import Chart, LocalChartOpts

nginx_ingress = Chart(
    "nginx-ingress",
    LocalChartOpts(
        path="./nginx-ingress",
    ),
)
```
```csharp
using System.Threading.Tasks;
using Pulumi;
using Pulumi.Kubernetes.Helm;
using Pulumi.Kubernetes.Helm.V2;

class HelmStack : Stack
{
    public HelmStack()
    {
        var nginx = new Chart("nginx-ingress", new LocalChartArgs
        {
            Path = "./nginx-ingress",
        });

    }
}
```
```go
package main

import (
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v2"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
			Path: pulumi.String("./nginx-ingress"),
		})
		if err != nil {
			return err
		}

		return nil
	})
}
```
{{% /example %}}
{{% example %}}
### Remote Chart

```typescript
import * as k8s from "@pulumi/kubernetes";

const nginxIngress = new k8s.helm.v2.Chart("nginx-ingress", {
    chart: "nginx-ingress",
    version: "1.24.4",
    fetchOpts:{
        repo: "https://charts.helm.sh/stable",
    },
});
```
```python
from pulumi_kubernetes.helm.v2 import Chart, ChartOpts, FetchOpts

nginx_ingress = Chart(
    "nginx-ingress",
    ChartOpts(
        chart="nginx-ingress",
        version="1.24.4",
        fetch_opts=FetchOpts(
            repo="https://charts.helm.sh/stable",
        ),
    ),
)
```
```csharp
using System.Threading.Tasks;
using Pulumi;
using Pulumi.Kubernetes.Helm;
using Pulumi.Kubernetes.Helm.V2;

class HelmStack : Stack
{
    public HelmStack()
    {
        var nginx = new Chart("nginx-ingress", new ChartArgs
        {
            Chart = "nginx-ingress",
            Version = "1.24.4",
            FetchOptions = new ChartFetchArgs
            {
                Repo = "https://charts.helm.sh/stable"
            }
        });

    }
}
```
```go
package main

import (
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v2"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.run(func(ctx *pulumi.context) error {
		_, err := helm.newchart(ctx, "nginx-ingress", helm.chartargs{
			chart:   pulumi.string("nginx-ingress"),
			version: pulumi.string("1.24.4"),
			fetchargs: helm.fetchargs{
				repo: pulumi.string("https://charts.helm.sh/stable"),
			},
		})
		if err != nil {
			return err
		}

		return nil
	})
}
```

{{% /example %}}
{{% example %}}
### Set Chart Values

```typescript
import * as k8s from "@pulumi/kubernetes";

const nginxIngress = new k8s.helm.v2.Chart("nginx-ingress", {
    chart: "nginx-ingress",
    version: "1.24.4",
    fetchOpts:{
        repo: "https://charts.helm.sh/stable",
    },
    values: {
        controller: {
            metrics: {
                enabled: true,
            }
        }
    },
});
```
```python
from pulumi_kubernetes.helm.v2 import Chart, ChartOpts, FetchOpts

nginx_ingress = Chart(
    "nginx-ingress",
    ChartOpts(
        chart="nginx-ingress",
        version="1.24.4",
        fetch_opts=FetchOpts(
            repo="https://charts.helm.sh/stable",
        ),
        values={
            "controller": {
                "metrics": {
                    "enabled": True,
                },
            },
        },
    ),
)
```
```csharp
using System.Collections.Generic;
using System.Threading.Tasks;
using Pulumi;
using Pulumi.Kubernetes.Helm;
using Pulumi.Kubernetes.Helm.V2;

class HelmStack : Stack
{
    public HelmStack()
    {
        var values = new Dictionary<string, object>
        {
            ["controller"] = new Dictionary<string, object>
            {
                ["metrics"] = new Dictionary<string, object>
                {
                    ["enabled"] = true
                }
            },
        };

        var nginx = new Chart("nginx-ingress", new ChartArgs
        {
            Chart = "nginx-ingress",
            Version = "1.24.4",
            FetchOptions = new ChartFetchArgs
            {
                Repo = "https://charts.helm.sh/stable"
            },
            Values = values,
        });

    }
}
```
```go
package main

import (
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v2"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
			Chart:   pulumi.String("nginx-ingress"),
			Version: pulumi.String("1.24.4"),
			FetchArgs: helm.FetchArgs{
				Repo: pulumi.String("https://charts.helm.sh/stable"),
			},
			Values: pulumi.Map{
				"controller": pulumi.Map{
					"metrics": pulumi.Map{
						"enabled": pulumi.Bool(true),
					},
				},
			},
		})
		if err != nil {
			return err
		}

		return nil
	})
}
```
{{% /example %}}
{{% example %}}
### Deploy Chart into Namespace

```typescript
import * as k8s from "@pulumi/kubernetes";

const nginxIngress = new k8s.helm.v2.Chart("nginx-ingress", {
    chart: "nginx-ingress",
    version: "1.24.4",
    namespace: "test-namespace",
    fetchOpts:{
        repo: "https://charts.helm.sh/stable",
    },
});
```
```python
from pulumi_kubernetes.helm.v2 import Chart, ChartOpts, FetchOpts

nginx_ingress = Chart(
    "nginx-ingress",
    ChartOpts(
        chart="nginx-ingress",
        version="1.24.4",
        namespace="test-namespace",
        fetch_opts=FetchOpts(
            repo="https://charts.helm.sh/stable",
        ),
    ),
)
```
```csharp
using System.Threading.Tasks;
using Pulumi;
using Pulumi.Kubernetes.Helm;
using Pulumi.Kubernetes.Helm.V2;

class HelmStack : Stack
{
    public HelmStack()
    {
        var nginx = new Chart("nginx-ingress", new ChartArgs
        {
            Chart = "nginx-ingress",
            Version = "1.24.4",
            Namespace = "test-namespace",
            FetchOptions = new ChartFetchArgs
            {
                Repo = "https://charts.helm.sh/stable"
            },
        });

    }
}
```
```go
package main

import (
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v2"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
			Chart:     pulumi.String("nginx-ingress"),
			Version:   pulumi.String("1.24.4"),
			Namespace: pulumi.String("test-namespace"),
			FetchArgs: helm.FetchArgs{
				Repo: pulumi.String("https://charts.helm.sh/stable"),
			},
		})
		if err != nil {
			return err
		}

		return nil
	})
}
```
{{% /example %}}
{{% example %}}
### Chart with Transformations

```typescript
import * as k8s from "@pulumi/kubernetes";

const nginxIngress = new k8s.helm.v2.Chart("nginx-ingress", {
    chart: "nginx-ingress",
    version: "1.24.4",
    fetchOpts:{
        repo: "https://charts.helm.sh/stable",
    },
    transformations: [
        // Make every service private to the cluster, i.e., turn all services into ClusterIP instead of LoadBalancer.
        (obj: any, opts: pulumi.CustomResourceOptions) => {
            if (obj.kind === "Service" && obj.apiVersion === "v1") {
                if (obj.spec && obj.spec.type && obj.spec.type === "LoadBalancer") {
                    obj.spec.type = "ClusterIP";
                }
            }
        },

        // Set a resource alias for a previous name.
        (obj: any, opts: pulumi.CustomResourceOptions) => {
            if (obj.kind === "Deployment") {
                opts.aliases = [{ name: "oldName" }]
            }
        },

        // Omit a resource from the Chart by transforming the specified resource definition to an empty List.
        (obj: any, opts: pulumi.CustomResourceOptions) => {
            if (obj.kind === "Pod" && obj.metadata.name === "test") {
                obj.apiVersion = "v1"
                obj.kind = "List"
            }
        },
    ],
});
```
```python
from pulumi_kubernetes.helm.v2 import Chart, ChartOpts, FetchOpts

# Make every service private to the cluster, i.e., turn all services into ClusterIP instead of LoadBalancer.
def make_service_private(obj, opts):
    if obj["kind"] == "Service" and obj["apiVersion"] == "v1":
        try:
            t = obj["spec"]["type"]
            if t == "LoadBalancer":
                obj["spec"]["type"] = "ClusterIP"
        except KeyError:
            pass


# Set a resource alias for a previous name.
def alias(obj, opts):
    if obj["kind"] == "Deployment":
        opts.aliases = ["oldName"]


# Omit a resource from the Chart by transforming the specified resource definition to an empty List.
def omit_resource(obj, opts):
    if obj["kind"] == "Pod" and obj["metadata"]["name"] == "test":
        obj["apiVersion"] = "v1"
        obj["kind"] = "List"


nginx_ingress = Chart(
    "nginx-ingress",
    ChartOpts(
        chart="nginx-ingress",
        version="1.24.4",
        fetch_opts=FetchOpts(
            repo="https://charts.helm.sh/stable",
        ),
        transformations=[make_service_private, alias, omit_resource],
    ),
)
```
```csharp
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi;
using Pulumi.Kubernetes.Helm;
using Pulumi.Kubernetes.Helm.V2;

class HelmStack : Stack
{
    public HelmStack()
    {
        var nginx = new Chart("nginx-ingress", new ChartArgs
        {
            Chart = "nginx-ingress",
            Version = "1.24.4",
            FetchOptions = new ChartFetchArgs
            {
                Repo = "https://charts.helm.sh/stable"
            },
            Transformations =
            {
                LoadBalancerToClusterIP,
                ResourceAlias,
                OmitTestPod,
            }

        });

        // Make every service private to the cluster, i.e., turn all services into ClusterIP instead of LoadBalancer.
        ImmutableDictionary<string, object> LoadBalancerToClusterIP(ImmutableDictionary<string, object> obj, CustomResourceOptions opts)
        {
            if ((string)obj["kind"] == "Service" && (string)obj["apiVersion"] == "v1")
            {
                var spec = (ImmutableDictionary<string, object>)obj["spec"];
                if (spec != null && (string)spec["type"] == "LoadBalancer")
                {
                    return obj.SetItem("spec", spec.SetItem("type", "ClusterIP"));
                }
            }

            return obj;
        }

        // Set a resource alias for a previous name.
        ImmutableDictionary<string, object> ResourceAlias(ImmutableDictionary<string, object> obj, CustomResourceOptions opts)
        {
            if ((string)obj["kind"] == "Deployment")
            {
                opts.Aliases.Add(new Alias { Name = "oldName" });
            }

            return obj;
        }

        // Omit a resource from the Chart by transforming the specified resource definition to an empty List.
        ImmutableDictionary<string, object> OmitTestPod(ImmutableDictionary<string, object> obj, CustomResourceOptions opts)
        {
            var metadata = (ImmutableDictionary<string, object>)obj["metadata"];
            if ((string)obj["kind"] == "Pod" && (string)metadata["name"] == "test")
            {
                return new Dictionary<string, object>
                {
                    ["apiVersion"] = "v1",
                    ["kind"] = "List",
                    ["items"] = new Dictionary<string, object>(),
                }.ToImmutableDictionary();
            }

            return obj;
        }
    }
}
```
```go
package main

import (
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/helm/v2"
	"github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/yaml"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		_, err := helm.NewChart(ctx, "nginx-ingress", helm.ChartArgs{
			Chart:   pulumi.String("nginx-ingress"),
			Version: pulumi.String("1.24.4"),
			FetchArgs: helm.FetchArgs{
				Repo: pulumi.String("https://charts.helm.sh/stable"),
			},
			Transformations: []yaml.Transformation{
				// Make every service private to the cluster, i.e., turn all services into ClusterIP
				// instead of LoadBalancer.
				func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
					if state["kind"] == "Service" {
						spec := state["spec"].(map[string]interface{})
						spec["type"] = "ClusterIP"
					}
				},

				// Set a resource alias for a previous name.
				func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
					if state["kind"] == "Deployment" {
						aliases := pulumi.Aliases([]pulumi.Alias{
							{
								Name: pulumi.String("oldName"),
							},
						})
						opts = append(opts, aliases)
					}
				},

				// Omit a resource from the Chart by transforming the specified resource definition
				// to an empty List.
				func(state map[string]interface{}, opts ...pulumi.ResourceOption) {
					name := state["metadata"].(map[string]interface{})["name"]
					if state["kind"] == "Pod" && name == "test" {
						state["apiVersion"] = "core/v1"
						state["kind"] = "List"
					}
				},
			},
		})
		if err != nil {
			return err
		}

		return nil
	})
}
```
{{% /example %}}
{{% /examples %}}