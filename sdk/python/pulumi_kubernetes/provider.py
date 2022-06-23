# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from ._inputs import *

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 cluster: Optional[pulumi.Input[str]] = None,
                 context: Optional[pulumi.Input[str]] = None,
                 delete_unreachable: Optional[pulumi.Input[bool]] = None,
                 enable_config_map_mutable: Optional[pulumi.Input[bool]] = None,
                 enable_dry_run: Optional[pulumi.Input[bool]] = None,
                 enable_replace_crd: Optional[pulumi.Input[bool]] = None,
                 helm_release_settings: Optional[pulumi.Input['HelmReleaseSettingsArgs']] = None,
                 kube_client_settings: Optional[pulumi.Input['KubeClientSettingsArgs']] = None,
                 kubeconfig: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 render_yaml_to_directory: Optional[pulumi.Input[str]] = None,
                 suppress_deprecation_warnings: Optional[pulumi.Input[bool]] = None,
                 suppress_helm_hook_warnings: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[str] cluster: If present, the name of the kubeconfig cluster to use.
        :param pulumi.Input[str] context: If present, the name of the kubeconfig context to use.
        :param pulumi.Input[bool] delete_unreachable: If present and set to true, the provider will delete resources associated with an unreachable Kubernetes cluster from Pulumi state
        :param pulumi.Input[bool] enable_config_map_mutable: BETA FEATURE - If present and set to true, allow ConfigMaps to be mutated.
               This feature is in developer preview, and is disabled by default.
               
               This config can be specified in the following ways using this precedence:
               1. This `enableConfigMapMutable` parameter.
               2. The `PULUMI_K8S_ENABLE_CONFIGMAP_MUTABLE` environment variable.
        :param pulumi.Input[bool] enable_dry_run: BETA FEATURE - If present and set to true, enable server-side diff calculations.
               This feature is in developer preview, and is disabled by default.
        :param pulumi.Input[bool] enable_replace_crd: Obsolete. This option has no effect.
        :param pulumi.Input['HelmReleaseSettingsArgs'] helm_release_settings: Options to configure the Helm Release resource.
        :param pulumi.Input['KubeClientSettingsArgs'] kube_client_settings: Options for tuning the Kubernetes client used by a Provider.
        :param pulumi.Input[str] kubeconfig: The contents of a kubeconfig file or the path to a kubeconfig file.
        :param pulumi.Input[str] namespace: If present, the default namespace to use. This flag is ignored for cluster-scoped resources.
               
               A namespace can be specified in multiple places, and the precedence is as follows:
               1. `.metadata.namespace` set on the resource.
               2. This `namespace` parameter.
               3. `namespace` set for the active context in the kubeconfig.
        :param pulumi.Input[str] render_yaml_to_directory: BETA FEATURE - If present, render resource manifests to this directory. In this mode, resources will not
               be created on a Kubernetes cluster, but the rendered manifests will be kept in sync with changes
               to the Pulumi program. This feature is in developer preview, and is disabled by default.
               
               Note that some computed Outputs such as status fields will not be populated
               since the resources are not created on a Kubernetes cluster. These Output values will remain undefined,
               and may result in an error if they are referenced by other resources. Also note that any secret values
               used in these resources will be rendered in plaintext to the resulting YAML.
        :param pulumi.Input[bool] suppress_deprecation_warnings: If present and set to true, suppress apiVersion deprecation warnings from the CLI.
        :param pulumi.Input[bool] suppress_helm_hook_warnings: If present and set to true, suppress unsupported Helm hook warnings from the CLI.
        """
        if cluster is not None:
            pulumi.set(__self__, "cluster", cluster)
        if context is not None:
            pulumi.set(__self__, "context", context)
        if delete_unreachable is not None:
            pulumi.set(__self__, "delete_unreachable", delete_unreachable)
        if enable_config_map_mutable is None:
            enable_config_map_mutable = _utilities.get_env_bool('PULUMI_K8S_ENABLE_CONFIGMAP_MUTABLE')
        if enable_config_map_mutable is not None:
            pulumi.set(__self__, "enable_config_map_mutable", enable_config_map_mutable)
        if enable_dry_run is None:
            enable_dry_run = _utilities.get_env_bool('PULUMI_K8S_ENABLE_DRY_RUN')
        if enable_dry_run is not None:
            pulumi.set(__self__, "enable_dry_run", enable_dry_run)
        if enable_replace_crd is None:
            enable_replace_crd = _utilities.get_env_bool('PULUMI_K8S_ENABLE_REPLACE_CRD')
        if enable_replace_crd is not None:
            warnings.warn("""This option is deprecated, and will be removed in a future release.""", DeprecationWarning)
            pulumi.log.warn("""enable_replace_crd is deprecated: This option is deprecated, and will be removed in a future release.""")
        if enable_replace_crd is not None:
            pulumi.set(__self__, "enable_replace_crd", enable_replace_crd)
        if helm_release_settings is not None:
            pulumi.set(__self__, "helm_release_settings", helm_release_settings)
        if kube_client_settings is not None:
            pulumi.set(__self__, "kube_client_settings", kube_client_settings)
        if kubeconfig is None:
            kubeconfig = _utilities.get_env('KUBECONFIG')
        if kubeconfig is not None:
            pulumi.set(__self__, "kubeconfig", kubeconfig)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if render_yaml_to_directory is not None:
            pulumi.set(__self__, "render_yaml_to_directory", render_yaml_to_directory)
        if suppress_deprecation_warnings is None:
            suppress_deprecation_warnings = _utilities.get_env_bool('PULUMI_K8S_SUPPRESS_DEPRECATION_WARNINGS')
        if suppress_deprecation_warnings is not None:
            pulumi.set(__self__, "suppress_deprecation_warnings", suppress_deprecation_warnings)
        if suppress_helm_hook_warnings is None:
            suppress_helm_hook_warnings = _utilities.get_env_bool('PULUMI_K8S_SUPPRESS_HELM_HOOK_WARNINGS')
        if suppress_helm_hook_warnings is not None:
            pulumi.set(__self__, "suppress_helm_hook_warnings", suppress_helm_hook_warnings)

    @property
    @pulumi.getter
    def cluster(self) -> Optional[pulumi.Input[str]]:
        """
        If present, the name of the kubeconfig cluster to use.
        """
        return pulumi.get(self, "cluster")

    @cluster.setter
    def cluster(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster", value)

    @property
    @pulumi.getter
    def context(self) -> Optional[pulumi.Input[str]]:
        """
        If present, the name of the kubeconfig context to use.
        """
        return pulumi.get(self, "context")

    @context.setter
    def context(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "context", value)

    @property
    @pulumi.getter(name="deleteUnreachable")
    def delete_unreachable(self) -> Optional[pulumi.Input[bool]]:
        """
        If present and set to true, the provider will delete resources associated with an unreachable Kubernetes cluster from Pulumi state
        """
        return pulumi.get(self, "delete_unreachable")

    @delete_unreachable.setter
    def delete_unreachable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "delete_unreachable", value)

    @property
    @pulumi.getter(name="enableConfigMapMutable")
    def enable_config_map_mutable(self) -> Optional[pulumi.Input[bool]]:
        """
        BETA FEATURE - If present and set to true, allow ConfigMaps to be mutated.
        This feature is in developer preview, and is disabled by default.

        This config can be specified in the following ways using this precedence:
        1. This `enableConfigMapMutable` parameter.
        2. The `PULUMI_K8S_ENABLE_CONFIGMAP_MUTABLE` environment variable.
        """
        return pulumi.get(self, "enable_config_map_mutable")

    @enable_config_map_mutable.setter
    def enable_config_map_mutable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_config_map_mutable", value)

    @property
    @pulumi.getter(name="enableDryRun")
    def enable_dry_run(self) -> Optional[pulumi.Input[bool]]:
        """
        BETA FEATURE - If present and set to true, enable server-side diff calculations.
        This feature is in developer preview, and is disabled by default.
        """
        return pulumi.get(self, "enable_dry_run")

    @enable_dry_run.setter
    def enable_dry_run(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_dry_run", value)

    @property
    @pulumi.getter(name="enableReplaceCRD")
    def enable_replace_crd(self) -> Optional[pulumi.Input[bool]]:
        """
        Obsolete. This option has no effect.
        """
        return pulumi.get(self, "enable_replace_crd")

    @enable_replace_crd.setter
    def enable_replace_crd(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_replace_crd", value)

    @property
    @pulumi.getter(name="helmReleaseSettings")
    def helm_release_settings(self) -> Optional[pulumi.Input['HelmReleaseSettingsArgs']]:
        """
        Options to configure the Helm Release resource.
        """
        return pulumi.get(self, "helm_release_settings")

    @helm_release_settings.setter
    def helm_release_settings(self, value: Optional[pulumi.Input['HelmReleaseSettingsArgs']]):
        pulumi.set(self, "helm_release_settings", value)

    @property
    @pulumi.getter(name="kubeClientSettings")
    def kube_client_settings(self) -> Optional[pulumi.Input['KubeClientSettingsArgs']]:
        """
        Options for tuning the Kubernetes client used by a Provider.
        """
        return pulumi.get(self, "kube_client_settings")

    @kube_client_settings.setter
    def kube_client_settings(self, value: Optional[pulumi.Input['KubeClientSettingsArgs']]):
        pulumi.set(self, "kube_client_settings", value)

    @property
    @pulumi.getter
    def kubeconfig(self) -> Optional[pulumi.Input[str]]:
        """
        The contents of a kubeconfig file or the path to a kubeconfig file.
        """
        return pulumi.get(self, "kubeconfig")

    @kubeconfig.setter
    def kubeconfig(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kubeconfig", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        If present, the default namespace to use. This flag is ignored for cluster-scoped resources.

        A namespace can be specified in multiple places, and the precedence is as follows:
        1. `.metadata.namespace` set on the resource.
        2. This `namespace` parameter.
        3. `namespace` set for the active context in the kubeconfig.
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter(name="renderYamlToDirectory")
    def render_yaml_to_directory(self) -> Optional[pulumi.Input[str]]:
        """
        BETA FEATURE - If present, render resource manifests to this directory. In this mode, resources will not
        be created on a Kubernetes cluster, but the rendered manifests will be kept in sync with changes
        to the Pulumi program. This feature is in developer preview, and is disabled by default.

        Note that some computed Outputs such as status fields will not be populated
        since the resources are not created on a Kubernetes cluster. These Output values will remain undefined,
        and may result in an error if they are referenced by other resources. Also note that any secret values
        used in these resources will be rendered in plaintext to the resulting YAML.
        """
        return pulumi.get(self, "render_yaml_to_directory")

    @render_yaml_to_directory.setter
    def render_yaml_to_directory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "render_yaml_to_directory", value)

    @property
    @pulumi.getter(name="suppressDeprecationWarnings")
    def suppress_deprecation_warnings(self) -> Optional[pulumi.Input[bool]]:
        """
        If present and set to true, suppress apiVersion deprecation warnings from the CLI.
        """
        return pulumi.get(self, "suppress_deprecation_warnings")

    @suppress_deprecation_warnings.setter
    def suppress_deprecation_warnings(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "suppress_deprecation_warnings", value)

    @property
    @pulumi.getter(name="suppressHelmHookWarnings")
    def suppress_helm_hook_warnings(self) -> Optional[pulumi.Input[bool]]:
        """
        If present and set to true, suppress unsupported Helm hook warnings from the CLI.
        """
        return pulumi.get(self, "suppress_helm_hook_warnings")

    @suppress_helm_hook_warnings.setter
    def suppress_helm_hook_warnings(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "suppress_helm_hook_warnings", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster: Optional[pulumi.Input[str]] = None,
                 context: Optional[pulumi.Input[str]] = None,
                 delete_unreachable: Optional[pulumi.Input[bool]] = None,
                 enable_config_map_mutable: Optional[pulumi.Input[bool]] = None,
                 enable_dry_run: Optional[pulumi.Input[bool]] = None,
                 enable_replace_crd: Optional[pulumi.Input[bool]] = None,
                 helm_release_settings: Optional[pulumi.Input[pulumi.InputType['HelmReleaseSettingsArgs']]] = None,
                 kube_client_settings: Optional[pulumi.Input[pulumi.InputType['KubeClientSettingsArgs']]] = None,
                 kubeconfig: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 render_yaml_to_directory: Optional[pulumi.Input[str]] = None,
                 suppress_deprecation_warnings: Optional[pulumi.Input[bool]] = None,
                 suppress_helm_hook_warnings: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        The provider type for the kubernetes package.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster: If present, the name of the kubeconfig cluster to use.
        :param pulumi.Input[str] context: If present, the name of the kubeconfig context to use.
        :param pulumi.Input[bool] delete_unreachable: If present and set to true, the provider will delete resources associated with an unreachable Kubernetes cluster from Pulumi state
        :param pulumi.Input[bool] enable_config_map_mutable: BETA FEATURE - If present and set to true, allow ConfigMaps to be mutated.
               This feature is in developer preview, and is disabled by default.
               
               This config can be specified in the following ways using this precedence:
               1. This `enableConfigMapMutable` parameter.
               2. The `PULUMI_K8S_ENABLE_CONFIGMAP_MUTABLE` environment variable.
        :param pulumi.Input[bool] enable_dry_run: BETA FEATURE - If present and set to true, enable server-side diff calculations.
               This feature is in developer preview, and is disabled by default.
        :param pulumi.Input[bool] enable_replace_crd: Obsolete. This option has no effect.
        :param pulumi.Input[pulumi.InputType['HelmReleaseSettingsArgs']] helm_release_settings: Options to configure the Helm Release resource.
        :param pulumi.Input[pulumi.InputType['KubeClientSettingsArgs']] kube_client_settings: Options for tuning the Kubernetes client used by a Provider.
        :param pulumi.Input[str] kubeconfig: The contents of a kubeconfig file or the path to a kubeconfig file.
        :param pulumi.Input[str] namespace: If present, the default namespace to use. This flag is ignored for cluster-scoped resources.
               
               A namespace can be specified in multiple places, and the precedence is as follows:
               1. `.metadata.namespace` set on the resource.
               2. This `namespace` parameter.
               3. `namespace` set for the active context in the kubeconfig.
        :param pulumi.Input[str] render_yaml_to_directory: BETA FEATURE - If present, render resource manifests to this directory. In this mode, resources will not
               be created on a Kubernetes cluster, but the rendered manifests will be kept in sync with changes
               to the Pulumi program. This feature is in developer preview, and is disabled by default.
               
               Note that some computed Outputs such as status fields will not be populated
               since the resources are not created on a Kubernetes cluster. These Output values will remain undefined,
               and may result in an error if they are referenced by other resources. Also note that any secret values
               used in these resources will be rendered in plaintext to the resulting YAML.
        :param pulumi.Input[bool] suppress_deprecation_warnings: If present and set to true, suppress apiVersion deprecation warnings from the CLI.
        :param pulumi.Input[bool] suppress_helm_hook_warnings: If present and set to true, suppress unsupported Helm hook warnings from the CLI.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ProviderArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the kubernetes package.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster: Optional[pulumi.Input[str]] = None,
                 context: Optional[pulumi.Input[str]] = None,
                 delete_unreachable: Optional[pulumi.Input[bool]] = None,
                 enable_config_map_mutable: Optional[pulumi.Input[bool]] = None,
                 enable_dry_run: Optional[pulumi.Input[bool]] = None,
                 enable_replace_crd: Optional[pulumi.Input[bool]] = None,
                 helm_release_settings: Optional[pulumi.Input[pulumi.InputType['HelmReleaseSettingsArgs']]] = None,
                 kube_client_settings: Optional[pulumi.Input[pulumi.InputType['KubeClientSettingsArgs']]] = None,
                 kubeconfig: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 render_yaml_to_directory: Optional[pulumi.Input[str]] = None,
                 suppress_deprecation_warnings: Optional[pulumi.Input[bool]] = None,
                 suppress_helm_hook_warnings: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProviderArgs.__new__(ProviderArgs)

            __props__.__dict__["cluster"] = cluster
            __props__.__dict__["context"] = context
            __props__.__dict__["delete_unreachable"] = pulumi.Output.from_input(delete_unreachable).apply(pulumi.runtime.to_json) if delete_unreachable is not None else None
            if enable_config_map_mutable is None:
                enable_config_map_mutable = _utilities.get_env_bool('PULUMI_K8S_ENABLE_CONFIGMAP_MUTABLE')
            __props__.__dict__["enable_config_map_mutable"] = pulumi.Output.from_input(enable_config_map_mutable).apply(pulumi.runtime.to_json) if enable_config_map_mutable is not None else None
            if enable_dry_run is None:
                enable_dry_run = _utilities.get_env_bool('PULUMI_K8S_ENABLE_DRY_RUN')
            __props__.__dict__["enable_dry_run"] = pulumi.Output.from_input(enable_dry_run).apply(pulumi.runtime.to_json) if enable_dry_run is not None else None
            if enable_replace_crd is None:
                enable_replace_crd = _utilities.get_env_bool('PULUMI_K8S_ENABLE_REPLACE_CRD')
            if enable_replace_crd is not None and not opts.urn:
                warnings.warn("""This option is deprecated, and will be removed in a future release.""", DeprecationWarning)
                pulumi.log.warn("""enable_replace_crd is deprecated: This option is deprecated, and will be removed in a future release.""")
            __props__.__dict__["enable_replace_crd"] = pulumi.Output.from_input(enable_replace_crd).apply(pulumi.runtime.to_json) if enable_replace_crd is not None else None
            __props__.__dict__["helm_release_settings"] = pulumi.Output.from_input(helm_release_settings).apply(pulumi.runtime.to_json) if helm_release_settings is not None else None
            __props__.__dict__["kube_client_settings"] = pulumi.Output.from_input(kube_client_settings).apply(pulumi.runtime.to_json) if kube_client_settings is not None else None
            if kubeconfig is None:
                kubeconfig = _utilities.get_env('KUBECONFIG')
            __props__.__dict__["kubeconfig"] = kubeconfig
            __props__.__dict__["namespace"] = namespace
            __props__.__dict__["render_yaml_to_directory"] = render_yaml_to_directory
            if suppress_deprecation_warnings is None:
                suppress_deprecation_warnings = _utilities.get_env_bool('PULUMI_K8S_SUPPRESS_DEPRECATION_WARNINGS')
            __props__.__dict__["suppress_deprecation_warnings"] = pulumi.Output.from_input(suppress_deprecation_warnings).apply(pulumi.runtime.to_json) if suppress_deprecation_warnings is not None else None
            if suppress_helm_hook_warnings is None:
                suppress_helm_hook_warnings = _utilities.get_env_bool('PULUMI_K8S_SUPPRESS_HELM_HOOK_WARNINGS')
            __props__.__dict__["suppress_helm_hook_warnings"] = pulumi.Output.from_input(suppress_helm_hook_warnings).apply(pulumi.runtime.to_json) if suppress_helm_hook_warnings is not None else None
        super(Provider, __self__).__init__(
            'kubernetes',
            resource_name,
            __props__,
            opts)

