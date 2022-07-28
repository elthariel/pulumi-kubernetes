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
    /// CustomResourceConversion describes how to convert different versions of a CR.
    /// </summary>
    public class CustomResourceConversionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// strategy specifies how custom resources are converted between versions. Allowed values are: - `None`: The converter only change the apiVersion and would not touch any other field in the custom resource. - `Webhook`: API Server will call to an external webhook to do the conversion. Additional information
        ///   is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.
        /// </summary>
        [Input("strategy", required: true)]
        public Input<string> Strategy { get; set; } = null!;

        /// <summary>
        /// webhook describes how to call the conversion webhook. Required when `strategy` is set to `Webhook`.
        /// </summary>
        [Input("webhook")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1.WebhookConversionArgs>? Webhook { get; set; }

        public CustomResourceConversionArgs()
        {
        }
        public static new CustomResourceConversionArgs Empty => new CustomResourceConversionArgs();
    }
}
