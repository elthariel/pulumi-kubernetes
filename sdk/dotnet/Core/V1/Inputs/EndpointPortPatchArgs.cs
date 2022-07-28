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
    /// EndpointPort is a tuple that describes a single port.
    /// </summary>
    public class EndpointPortPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The application protocol for this port. This field follows standard Kubernetes label syntax. Un-prefixed names are reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names). Non-standard protocols should use prefixed names such as mycompany.com/my-custom-protocol.
        /// </summary>
        [Input("appProtocol")]
        public Input<string>? AppProtocol { get; set; }

        /// <summary>
        /// The name of this port.  This must match the 'name' field in the corresponding ServicePort. Must be a DNS_LABEL. Optional only if one port is defined.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The port number of the endpoint.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The IP protocol for this port. Must be UDP, TCP, or SCTP. Default is TCP.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        public EndpointPortPatchArgs()
        {
        }
        public static new EndpointPortPatchArgs Empty => new EndpointPortPatchArgs();
    }
}
