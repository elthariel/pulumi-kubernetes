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
    /// FlexPersistentVolumeSource represents a generic persistent volume resource that is provisioned/attached using an exec based plugin.
    /// </summary>
    public class FlexPersistentVolumeSourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// driver is the name of the driver to use for this volume.
        /// </summary>
        [Input("driver", required: true)]
        public Input<string> Driver { get; set; } = null!;

        /// <summary>
        /// fsType is the Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
        /// </summary>
        [Input("fsType")]
        public Input<string>? FsType { get; set; }

        [Input("options")]
        private InputMap<string>? _options;

        /// <summary>
        /// options is Optional: this field holds extra command options if any.
        /// </summary>
        public InputMap<string> Options
        {
            get => _options ?? (_options = new InputMap<string>());
            set => _options = value;
        }

        /// <summary>
        /// readOnly is Optional: defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        /// <summary>
        /// secretRef is Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.SecretReferenceArgs>? SecretRef { get; set; }

        public FlexPersistentVolumeSourceArgs()
        {
        }
        public static new FlexPersistentVolumeSourceArgs Empty => new FlexPersistentVolumeSourceArgs();
    }
}
