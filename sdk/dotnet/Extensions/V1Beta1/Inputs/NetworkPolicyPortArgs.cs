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
    /// DEPRECATED 1.9 - This group version of NetworkPolicyPort is deprecated by networking/v1/NetworkPolicyPort.
    /// </summary>
    public class NetworkPolicyPortArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified, the port on the given protocol.  This can either be a numerical or named port on a pod.  If this field is not provided, this matches all port names and numbers. If present, only traffic on the specified protocol AND port will be matched.
        /// </summary>
        [Input("port")]
        public InputUnion<int, string>? Port { get; set; }

        /// <summary>
        /// Optional.  The protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        public NetworkPolicyPortArgs()
        {
        }
        public static new NetworkPolicyPortArgs Empty => new NetworkPolicyPortArgs();
    }
}
