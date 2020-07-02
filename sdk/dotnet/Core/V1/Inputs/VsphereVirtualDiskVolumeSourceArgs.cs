// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// Represents a vSphere volume resource.
    /// </summary>
    public class VsphereVirtualDiskVolumeSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
        /// </summary>
        [Input("storagePolicyID")]
        public Input<string>? StoragePolicyID { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile name.
        /// </summary>
        [Input("storagePolicyName")]
        public Input<string>? StoragePolicyName { get; set; }

        /// <summary>
        /// Path that identifies vSphere volume vmdk
        /// </summary>
        [Input("volumePath", required: true)]
        public Input<string> VolumePath { get; set; } = null!;

        public VsphereVirtualDiskVolumeSourceArgs()
        {
        }
    }
}