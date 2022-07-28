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
    /// volumeDevice describes a mapping of a raw block device within a container.
    /// </summary>
    public class VolumeDeviceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// devicePath is the path inside of the container that the device will be mapped to.
        /// </summary>
        [Input("devicePath", required: true)]
        public Input<string> DevicePath { get; set; } = null!;

        /// <summary>
        /// name must match the name of a persistentVolumeClaim in the pod
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public VolumeDeviceArgs()
        {
        }
        public static new VolumeDeviceArgs Empty => new VolumeDeviceArgs();
    }
}
