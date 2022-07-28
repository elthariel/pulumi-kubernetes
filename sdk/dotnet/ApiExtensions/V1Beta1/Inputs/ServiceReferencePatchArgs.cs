// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1
{

    /// <summary>
    /// ServiceReference holds a reference to Service.legacy.k8s.io
    /// </summary>
    public class ServiceReferencePatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// name is the name of the service. Required
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// namespace is the namespace of the service. Required
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// path is an optional URL path at which the webhook will be contacted.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// port is an optional service port at which the webhook will be contacted. `port` should be a valid port number (1-65535, inclusive). Defaults to 443 for backward compatibility.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        public ServiceReferencePatchArgs()
        {
        }
        public static new ServiceReferencePatchArgs Empty => new ServiceReferencePatchArgs();
    }
}
