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
    /// CustomResourceConversion describes how to convert different versions of a CR.
    /// </summary>
    public class CustomResourceConversionArgs : global::Pulumi.ResourceArgs
    {
        [Input("conversionReviewVersions")]
        private InputList<string>? _conversionReviewVersions;

        /// <summary>
        /// conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail. Defaults to `["v1beta1"]`.
        /// </summary>
        public InputList<string> ConversionReviewVersions
        {
            get => _conversionReviewVersions ?? (_conversionReviewVersions = new InputList<string>());
            set => _conversionReviewVersions = value;
        }

        /// <summary>
        /// strategy specifies how custom resources are converted between versions. Allowed values are: - `None`: The converter only change the apiVersion and would not touch any other field in the custom resource. - `Webhook`: API Server will call to an external webhook to do the conversion. Additional information
        ///   is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhookClientConfig to be set.
        /// </summary>
        [Input("strategy", required: true)]
        public Input<string> Strategy { get; set; } = null!;

        /// <summary>
        /// webhookClientConfig is the instructions for how to call the webhook if strategy is `Webhook`. Required when `strategy` is set to `Webhook`.
        /// </summary>
        [Input("webhookClientConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.WebhookClientConfigArgs>? WebhookClientConfig { get; set; }

        public CustomResourceConversionArgs()
        {
        }
        public static new CustomResourceConversionArgs Empty => new CustomResourceConversionArgs();
    }
}
