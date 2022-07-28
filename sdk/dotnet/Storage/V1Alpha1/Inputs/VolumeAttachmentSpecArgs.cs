// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1
{

    /// <summary>
    /// VolumeAttachmentSpec is the specification of a VolumeAttachment request.
    /// </summary>
    public class VolumeAttachmentSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().
        /// </summary>
        [Input("attacher", required: true)]
        public Input<string> Attacher { get; set; } = null!;

        /// <summary>
        /// The node that the volume should be attached to.
        /// </summary>
        [Input("nodeName", required: true)]
        public Input<string> NodeName { get; set; } = null!;

        /// <summary>
        /// Source represents the volume that should be attached.
        /// </summary>
        [Input("source", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.VolumeAttachmentSourceArgs> Source { get; set; } = null!;

        public VolumeAttachmentSpecArgs()
        {
        }
        public static new VolumeAttachmentSpecArgs Empty => new VolumeAttachmentSpecArgs();
    }
}
