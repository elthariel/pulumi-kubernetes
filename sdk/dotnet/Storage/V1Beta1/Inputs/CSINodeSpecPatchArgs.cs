// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1Beta1
{

    /// <summary>
    /// CSINodeSpec holds information about the specification of all CSI drivers installed on a node
    /// </summary>
    public class CSINodeSpecPatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("drivers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Beta1.CSINodeDriverPatchArgs>? _drivers;

        /// <summary>
        /// drivers is a list of information of all CSI Drivers existing on a node. If all drivers in the list are uninstalled, this can become empty.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Beta1.CSINodeDriverPatchArgs> Drivers
        {
            get => _drivers ?? (_drivers = new InputList<Pulumi.Kubernetes.Types.Inputs.Storage.V1Beta1.CSINodeDriverPatchArgs>());
            set => _drivers = value;
        }

        public CSINodeSpecPatchArgs()
        {
        }
        public static new CSINodeSpecPatchArgs Empty => new CSINodeSpecPatchArgs();
    }
}
