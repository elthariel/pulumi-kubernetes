// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1
{

    /// <summary>
    /// ExternalDocumentation allows referencing an external resource for extended documentation.
    /// </summary>
    public class ExternalDocumentationArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public ExternalDocumentationArgs()
        {
        }
        public static new ExternalDocumentationArgs Empty => new ExternalDocumentationArgs();
    }
}
