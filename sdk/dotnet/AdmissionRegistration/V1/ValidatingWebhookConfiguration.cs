// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.AdmissionRegistration.V1
{
    /// <summary>
    /// ValidatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and object without changing it.
    /// </summary>
    [KubernetesResourceType("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfiguration")]
    public partial class ValidatingWebhookConfiguration : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Webhooks is a list of webhooks and the affected resources and operations.
        /// </summary>
        [Output("webhooks")]
        public Output<ImmutableArray<Pulumi.Kubernetes.Types.Outputs.AdmissionRegistration.V1.ValidatingWebhook>> Webhooks { get; private set; } = null!;


        /// <summary>
        /// Create a ValidatingWebhookConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ValidatingWebhookConfiguration(string name, Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookConfigurationArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfiguration", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal ValidatingWebhookConfiguration(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfiguration", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private ValidatingWebhookConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookConfigurationArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookConfigurationArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookConfigurationArgs();
            args.ApiVersion = "admissionregistration.k8s.io/v1";
            args.Kind = "ValidatingWebhookConfiguration";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new global::Pulumi.Alias { Type = "kubernetes:admissionregistration.k8s.io/v1beta1:ValidatingWebhookConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ValidatingWebhookConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ValidatingWebhookConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ValidatingWebhookConfiguration(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1
{

    public class ValidatingWebhookConfigurationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("webhooks")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookArgs>? _webhooks;

        /// <summary>
        /// Webhooks is a list of webhooks and the affected resources and operations.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookArgs> Webhooks
        {
            get => _webhooks ?? (_webhooks = new InputList<Pulumi.Kubernetes.Types.Inputs.AdmissionRegistration.V1.ValidatingWebhookArgs>());
            set => _webhooks = value;
        }

        public ValidatingWebhookConfigurationArgs()
        {
        }
        public static new ValidatingWebhookConfigurationArgs Empty => new ValidatingWebhookConfigurationArgs();
    }
}
