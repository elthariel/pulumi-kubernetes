// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Extensions.V1Beta1
{
    /// <summary>
    /// Patch resources are used to modify existing Kubernetes resources by using
    /// Server-Side Apply updates. The name of the resource must be specified, but all other properties are optional. More than
    /// one patch may be applied to the same resource, and a random FieldManager name will be used for each Patch resource.
    /// Conflicts will result in an error by default, but can be forced using the "pulumi.com/patchForce" annotation. See the
    /// [Server-Side Apply Docs](https://www.pulumi.com/registry/packages/kubernetes/installation-configuration/#server-side-apply) for
    /// additional information about using Server-Side Apply to manage Kubernetes resources with Pulumi.
    /// DaemonSet represents the configuration of a daemon set.
    /// </summary>
    [Obsolete(@"extensions/v1beta1/DaemonSet is deprecated by apps/v1/DaemonSet and not supported by Kubernetes v1.16+ clusters.")]
    [KubernetesResourceType("kubernetes:extensions/v1beta1:DaemonSetPatch")]
    public partial class DaemonSetPatch : KubernetesResource
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
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMetaPatch> Metadata { get; private set; } = null!;

        /// <summary>
        /// The desired behavior of this daemon set. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Extensions.V1Beta1.DaemonSetSpecPatch> Spec { get; private set; } = null!;

        /// <summary>
        /// The current status of this daemon set. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Extensions.V1Beta1.DaemonSetStatusPatch> Status { get; private set; } = null!;


        /// <summary>
        /// Create a DaemonSetPatch resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DaemonSetPatch(string name, Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.DaemonSetPatchArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:extensions/v1beta1:DaemonSetPatch", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal DaemonSetPatch(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:extensions/v1beta1:DaemonSetPatch", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private DaemonSetPatch(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:extensions/v1beta1:DaemonSetPatch", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.DaemonSetPatchArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.DaemonSetPatchArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.DaemonSetPatchArgs();
            args.ApiVersion = "extensions/v1beta1";
            args.Kind = "DaemonSet";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new global::Pulumi.Alias { Type = "kubernetes:apps/v1:DaemonSetPatch"},
                    new global::Pulumi.Alias { Type = "kubernetes:apps/v1beta2:DaemonSetPatch"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DaemonSetPatch resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DaemonSetPatch Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DaemonSetPatch(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1
{

    public class DaemonSetPatchArgs : global::Pulumi.ResourceArgs
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
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [Input("metadata", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaPatchArgs> Metadata { get; set; } = null!;

        /// <summary>
        /// The desired behavior of this daemon set. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.DaemonSetSpecPatchArgs>? Spec { get; set; }

        public DaemonSetPatchArgs()
        {
        }
        public static new DaemonSetPatchArgs Empty => new DaemonSetPatchArgs();
    }
}
