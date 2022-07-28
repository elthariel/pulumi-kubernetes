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
    /// HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.
    /// </summary>
    public class HTTPIngressRuleValuePatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("paths")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.HTTPIngressPathPatchArgs>? _paths;

        /// <summary>
        /// A collection of paths that map requests to backends.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.HTTPIngressPathPatchArgs> Paths
        {
            get => _paths ?? (_paths = new InputList<Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.HTTPIngressPathPatchArgs>());
            set => _paths = value;
        }

        public HTTPIngressRuleValuePatchArgs()
        {
        }
        public static new HTTPIngressRuleValuePatchArgs Empty => new HTTPIngressRuleValuePatchArgs();
    }
}
