// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1
{

    /// <summary>
    /// AllowedCSIDriver represents a single inline CSI Driver that is allowed to be used.
    /// </summary>
    public class AllowedCSIDriverPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the registered name of the CSI driver
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AllowedCSIDriverPatchArgs()
        {
        }
        public static new AllowedCSIDriverPatchArgs Empty => new AllowedCSIDriverPatchArgs();
    }
}
