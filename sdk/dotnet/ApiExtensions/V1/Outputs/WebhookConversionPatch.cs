// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.ApiExtensions.V1
{

    /// <summary>
    /// WebhookConversion describes how to call a conversion webhook
    /// </summary>
    [OutputType]
    public sealed class WebhookConversionPatch
    {
        /// <summary>
        /// clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.ApiExtensions.V1.WebhookClientConfigPatch ClientConfig;
        /// <summary>
        /// conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
        /// </summary>
        public readonly ImmutableArray<string> ConversionReviewVersions;

        [OutputConstructor]
        private WebhookConversionPatch(
            Pulumi.Kubernetes.Types.Outputs.ApiExtensions.V1.WebhookClientConfigPatch clientConfig,

            ImmutableArray<string> conversionReviewVersions)
        {
            ClientConfig = clientConfig;
            ConversionReviewVersions = conversionReviewVersions;
        }
    }
}