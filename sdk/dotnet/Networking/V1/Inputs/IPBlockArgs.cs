// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Networking.V1
{

    /// <summary>
    /// IPBlock describes a particular CIDR (Ex. "192.168.1.1/24","2001:db9::/64") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.
    /// </summary>
    public class IPBlockArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CIDR is a string representing the IP Block Valid examples are "192.168.1.1/24" or "2001:db9::/64"
        /// </summary>
        [Input("cidr", required: true)]
        public Input<string> Cidr { get; set; } = null!;

        [Input("except")]
        private InputList<string>? _except;

        /// <summary>
        /// Except is a slice of CIDRs that should not be included within an IP Block Valid examples are "192.168.1.1/24" or "2001:db9::/64" Except values will be rejected if they are outside the CIDR range
        /// </summary>
        public InputList<string> Except
        {
            get => _except ?? (_except = new InputList<string>());
            set => _except = value;
        }

        public IPBlockArgs()
        {
        }
        public static new IPBlockArgs Empty => new IPBlockArgs();
    }
}
