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
    /// DEPRECATED 1.9 - This group version of IPBlock is deprecated by networking/v1/IPBlock. IPBlock describes a particular CIDR (Ex. "192.168.1.1/24") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.
    /// </summary>
    public class IPBlockPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CIDR is a string representing the IP Block Valid examples are "192.168.1.1/24"
        /// </summary>
        [Input("cidr")]
        public Input<string>? Cidr { get; set; }

        [Input("except")]
        private InputList<string>? _except;

        /// <summary>
        /// Except is a slice of CIDRs that should not be included within an IP Block Valid examples are "192.168.1.1/24" Except values will be rejected if they are outside the CIDR range
        /// </summary>
        public InputList<string> Except
        {
            get => _except ?? (_except = new InputList<string>());
            set => _except = value;
        }

        public IPBlockPatchArgs()
        {
        }
        public static new IPBlockPatchArgs Empty => new IPBlockPatchArgs();
    }
}
