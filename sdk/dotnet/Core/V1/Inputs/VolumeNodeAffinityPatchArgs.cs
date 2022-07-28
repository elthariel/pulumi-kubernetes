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
    /// VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.
    /// </summary>
    public class VolumeNodeAffinityPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// required specifies hard node constraints that must be met.
        /// </summary>
        [Input("required")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.NodeSelectorPatchArgs>? Required { get; set; }

        public VolumeNodeAffinityPatchArgs()
        {
        }
        public static new VolumeNodeAffinityPatchArgs Empty => new VolumeNodeAffinityPatchArgs();
    }
}
