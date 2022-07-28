// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Networking.V1
{
    /// <summary>
    /// IngressClassList is a collection of IngressClasses.
    /// </summary>
    [KubernetesResourceType("kubernetes:networking.k8s.io/v1:IngressClassList")]
    public partial class IngressClassList : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Items is the list of IngressClasses.
        /// </summary>
        [Output("items")]
        public Output<ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Networking.V1.IngressClass>> Items { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Standard list metadata.
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ListMeta> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a IngressClassList resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IngressClassList(string name, Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassListArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:networking.k8s.io/v1:IngressClassList", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal IngressClassList(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:networking.k8s.io/v1:IngressClassList", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private IngressClassList(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:networking.k8s.io/v1:IngressClassList", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassListArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassListArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassListArgs();
            args.ApiVersion = "networking.k8s.io/v1";
            args.Kind = "IngressClassList";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IngressClassList resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IngressClassList Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IngressClassList(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Networking.V1
{

    public class IngressClassListArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("items", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassArgs>? _items;

        /// <summary>
        /// Items is the list of IngressClasses.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassArgs> Items
        {
            get => _items ?? (_items = new InputList<Pulumi.Kubernetes.Types.Inputs.Networking.V1.IngressClassArgs>());
            set => _items = value;
        }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Standard list metadata.
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ListMetaArgs>? Metadata { get; set; }

        public IngressClassListArgs()
        {
        }
        public static new IngressClassListArgs Empty => new IngressClassListArgs();
    }
}
