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
    /// ServiceBackendPort is the service port being referenced.
    /// </summary>
    public class ServiceBackendPortPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the name of the port on the Service. This is a mutually exclusive setting with "Number".
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Number is the numerical port number (e.g. 80) on the Service. This is a mutually exclusive setting with "Name".
        /// </summary>
        [Input("number")]
        public Input<int>? Number { get; set; }

        public ServiceBackendPortPatchArgs()
        {
        }
        public static new ServiceBackendPortPatchArgs Empty => new ServiceBackendPortPatchArgs();
    }
}
