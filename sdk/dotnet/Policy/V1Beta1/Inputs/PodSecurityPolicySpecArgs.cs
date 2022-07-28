// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1
{

    /// <summary>
    /// PodSecurityPolicySpec defines the policy enforced.
    /// </summary>
    public class PodSecurityPolicySpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// allowPrivilegeEscalation determines if a pod can request to allow privilege escalation. If unspecified, defaults to true.
        /// </summary>
        [Input("allowPrivilegeEscalation")]
        public Input<bool>? AllowPrivilegeEscalation { get; set; }

        [Input("allowedCSIDrivers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedCSIDriverArgs>? _allowedCSIDrivers;

        /// <summary>
        /// AllowedCSIDrivers is an allowlist of inline CSI drivers that must be explicitly set to be embedded within a pod spec. An empty value indicates that any CSI driver can be used for inline ephemeral volumes. This is a beta field, and is only honored if the API server enables the CSIInlineVolume feature gate.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedCSIDriverArgs> AllowedCSIDrivers
        {
            get => _allowedCSIDrivers ?? (_allowedCSIDrivers = new InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedCSIDriverArgs>());
            set => _allowedCSIDrivers = value;
        }

        [Input("allowedCapabilities")]
        private InputList<string>? _allowedCapabilities;

        /// <summary>
        /// allowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both allowedCapabilities and requiredDropCapabilities.
        /// </summary>
        public InputList<string> AllowedCapabilities
        {
            get => _allowedCapabilities ?? (_allowedCapabilities = new InputList<string>());
            set => _allowedCapabilities = value;
        }

        [Input("allowedFlexVolumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedFlexVolumeArgs>? _allowedFlexVolumes;

        /// <summary>
        /// allowedFlexVolumes is an allowlist of Flexvolumes.  Empty or nil indicates that all Flexvolumes may be used.  This parameter is effective only when the usage of the Flexvolumes is allowed in the "volumes" field.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedFlexVolumeArgs> AllowedFlexVolumes
        {
            get => _allowedFlexVolumes ?? (_allowedFlexVolumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedFlexVolumeArgs>());
            set => _allowedFlexVolumes = value;
        }

        [Input("allowedHostPaths")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedHostPathArgs>? _allowedHostPaths;

        /// <summary>
        /// allowedHostPaths is an allowlist of host paths. Empty indicates that all host paths may be used.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedHostPathArgs> AllowedHostPaths
        {
            get => _allowedHostPaths ?? (_allowedHostPaths = new InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.AllowedHostPathArgs>());
            set => _allowedHostPaths = value;
        }

        [Input("allowedProcMountTypes")]
        private InputList<string>? _allowedProcMountTypes;

        /// <summary>
        /// AllowedProcMountTypes is an allowlist of allowed ProcMountTypes. Empty or nil indicates that only the DefaultProcMountType may be used. This requires the ProcMountType feature flag to be enabled.
        /// </summary>
        public InputList<string> AllowedProcMountTypes
        {
            get => _allowedProcMountTypes ?? (_allowedProcMountTypes = new InputList<string>());
            set => _allowedProcMountTypes = value;
        }

        [Input("allowedUnsafeSysctls")]
        private InputList<string>? _allowedUnsafeSysctls;

        /// <summary>
        /// allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of allowed sysctls. Single * means all unsafe sysctls are allowed. Kubelet has to allowlist all allowed unsafe sysctls explicitly to avoid rejection.
        /// 
        /// Examples: e.g. "foo/*" allows "foo/bar", "foo/baz", etc. e.g. "foo.*" allows "foo.bar", "foo.baz", etc.
        /// </summary>
        public InputList<string> AllowedUnsafeSysctls
        {
            get => _allowedUnsafeSysctls ?? (_allowedUnsafeSysctls = new InputList<string>());
            set => _allowedUnsafeSysctls = value;
        }

        [Input("defaultAddCapabilities")]
        private InputList<string>? _defaultAddCapabilities;

        /// <summary>
        /// defaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capability in both defaultAddCapabilities and requiredDropCapabilities. Capabilities added here are implicitly allowed, and need not be included in the allowedCapabilities list.
        /// </summary>
        public InputList<string> DefaultAddCapabilities
        {
            get => _defaultAddCapabilities ?? (_defaultAddCapabilities = new InputList<string>());
            set => _defaultAddCapabilities = value;
        }

        /// <summary>
        /// defaultAllowPrivilegeEscalation controls the default setting for whether a process can gain more privileges than its parent process.
        /// </summary>
        [Input("defaultAllowPrivilegeEscalation")]
        public Input<bool>? DefaultAllowPrivilegeEscalation { get; set; }

        [Input("forbiddenSysctls")]
        private InputList<string>? _forbiddenSysctls;

        /// <summary>
        /// forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of forbidden sysctls. Single * means all sysctls are forbidden.
        /// 
        /// Examples: e.g. "foo/*" forbids "foo/bar", "foo/baz", etc. e.g. "foo.*" forbids "foo.bar", "foo.baz", etc.
        /// </summary>
        public InputList<string> ForbiddenSysctls
        {
            get => _forbiddenSysctls ?? (_forbiddenSysctls = new InputList<string>());
            set => _forbiddenSysctls = value;
        }

        /// <summary>
        /// fsGroup is the strategy that will dictate what fs group is used by the SecurityContext.
        /// </summary>
        [Input("fsGroup", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.FSGroupStrategyOptionsArgs> FsGroup { get; set; } = null!;

        /// <summary>
        /// hostIPC determines if the policy allows the use of HostIPC in the pod spec.
        /// </summary>
        [Input("hostIPC")]
        public Input<bool>? HostIPC { get; set; }

        /// <summary>
        /// hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.
        /// </summary>
        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        /// <summary>
        /// hostPID determines if the policy allows the use of HostPID in the pod spec.
        /// </summary>
        [Input("hostPID")]
        public Input<bool>? HostPID { get; set; }

        [Input("hostPorts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.HostPortRangeArgs>? _hostPorts;

        /// <summary>
        /// hostPorts determines which host port ranges are allowed to be exposed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.HostPortRangeArgs> HostPorts
        {
            get => _hostPorts ?? (_hostPorts = new InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.HostPortRangeArgs>());
            set => _hostPorts = value;
        }

        /// <summary>
        /// privileged determines if a pod can request to be run as privileged.
        /// </summary>
        [Input("privileged")]
        public Input<bool>? Privileged { get; set; }

        /// <summary>
        /// readOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.
        /// </summary>
        [Input("readOnlyRootFilesystem")]
        public Input<bool>? ReadOnlyRootFilesystem { get; set; }

        [Input("requiredDropCapabilities")]
        private InputList<string>? _requiredDropCapabilities;

        /// <summary>
        /// requiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.
        /// </summary>
        public InputList<string> RequiredDropCapabilities
        {
            get => _requiredDropCapabilities ?? (_requiredDropCapabilities = new InputList<string>());
            set => _requiredDropCapabilities = value;
        }

        /// <summary>
        /// RunAsGroup is the strategy that will dictate the allowable RunAsGroup values that may be set. If this field is omitted, the pod's RunAsGroup can take any value. This field requires the RunAsGroup feature gate to be enabled.
        /// </summary>
        [Input("runAsGroup")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.RunAsGroupStrategyOptionsArgs>? RunAsGroup { get; set; }

        /// <summary>
        /// runAsUser is the strategy that will dictate the allowable RunAsUser values that may be set.
        /// </summary>
        [Input("runAsUser", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.RunAsUserStrategyOptionsArgs> RunAsUser { get; set; } = null!;

        /// <summary>
        /// runtimeClass is the strategy that will dictate the allowable RuntimeClasses for a pod. If this field is omitted, the pod's runtimeClassName field is unrestricted. Enforcement of this field depends on the RuntimeClass feature gate being enabled.
        /// </summary>
        [Input("runtimeClass")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.RuntimeClassStrategyOptionsArgs>? RuntimeClass { get; set; }

        /// <summary>
        /// seLinux is the strategy that will dictate the allowable labels that may be set.
        /// </summary>
        [Input("seLinux", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.SELinuxStrategyOptionsArgs> SeLinux { get; set; } = null!;

        /// <summary>
        /// supplementalGroups is the strategy that will dictate what supplemental groups are used by the SecurityContext.
        /// </summary>
        [Input("supplementalGroups", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.SupplementalGroupsStrategyOptionsArgs> SupplementalGroups { get; set; } = null!;

        [Input("volumes")]
        private InputList<string>? _volumes;

        /// <summary>
        /// volumes is an allowlist of volume plugins. Empty indicates that no volumes may be used. To allow all volumes you may use '*'.
        /// </summary>
        public InputList<string> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<string>());
            set => _volumes = value;
        }

        public PodSecurityPolicySpecArgs()
        {
        }
        public static new PodSecurityPolicySpecArgs Empty => new PodSecurityPolicySpecArgs();
    }
}
