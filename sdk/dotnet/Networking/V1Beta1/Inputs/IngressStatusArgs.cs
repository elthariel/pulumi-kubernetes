// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Networking.V1Beta1
{

    /// <summary>
    /// IngressStatus describe the current state of the Ingress.
    /// </summary>
    public class IngressStatusArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// LoadBalancer contains the current status of the load-balancer.
        /// </summary>
        [Input("loadBalancer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.LoadBalancerStatusArgs>? LoadBalancer { get; set; }

        public IngressStatusArgs()
        {
        }
        public static new IngressStatusArgs Empty => new IngressStatusArgs();
    }
}
