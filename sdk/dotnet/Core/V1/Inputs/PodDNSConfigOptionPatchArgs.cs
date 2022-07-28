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
    /// PodDNSConfigOption defines DNS resolver options of a pod.
    /// </summary>
    public class PodDNSConfigOptionPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public PodDNSConfigOptionPatchArgs()
        {
        }
        public static new PodDNSConfigOptionPatchArgs Empty => new PodDNSConfigOptionPatchArgs();
    }
}
