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
    /// SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace
    /// </summary>
    public class SecretReferencePatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// name is unique within a namespace to reference a secret resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// namespace defines the space within which the secret name must be unique.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public SecretReferencePatchArgs()
        {
        }
        public static new SecretReferencePatchArgs Empty => new SecretReferencePatchArgs();
    }
}
