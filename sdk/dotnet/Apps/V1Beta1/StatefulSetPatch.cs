// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Apps.V1Beta1
{
    /// <summary>
    /// Patch resources are used to modify existing Kubernetes resources by using
    /// Server-Side Apply updates. The name of the resource must be specified, but all other properties are optional. More than
    /// one patch may be applied to the same resource, and a random FieldManager name will be used for each Patch resource.
    /// Conflicts will result in an error by default, but can be forced using the "pulumi.com/patchForce" annotation. See the
    /// [Server-Side Apply Docs](https://www.pulumi.com/registry/packages/kubernetes/installation-configuration/#server-side-apply) for
    /// additional information about using Server-Side Apply to manage Kubernetes resources with Pulumi.
    /// StatefulSet represents a set of pods with consistent identities. Identities are defined as:
    ///  - Network: A single stable DNS and hostname.
    ///  - Storage: As many VolumeClaims as requested.
    ///    The StatefulSet guarantees that a given network identity will always map to the same storage identity.
    /// 
    /// This resource waits until its status is ready before registering success
    /// for create/update, and populating output properties from the current state of the resource.
    /// The following conditions are used to determine whether the resource creation has
    /// succeeded or failed:
    /// 
    /// 1. The value of 'spec.replicas' matches '.status.replicas', '.status.currentReplicas',
    ///    and '.status.readyReplicas'.
    /// 2. The value of '.status.updateRevision' matches '.status.currentRevision'.
    /// 
    /// If the StatefulSet has not reached a Ready state after 10 minutes, it will
    /// time out and mark the resource update as Failed. You can override the default timeout value
    /// by setting the 'customTimeouts' option on the resource.
    /// </summary>
    [Obsolete(@"apps/v1beta1/StatefulSet is deprecated by apps/v1/StatefulSet and not supported by Kubernetes v1.16+ clusters.")]
    [KubernetesResourceType("kubernetes:apps/v1beta1:StatefulSetPatch")]
    public partial class StatefulSetPatch : KubernetesResource
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

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMetaPatch> Metadata { get; private set; } = null!;

        /// <summary>
        /// Spec defines the desired identities of pods in this set.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Beta1.StatefulSetSpecPatch> Spec { get; private set; } = null!;

        /// <summary>
        /// Status is the current status of Pods in this StatefulSet. This data may be out of date by some window of time.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Apps.V1Beta1.StatefulSetStatusPatch> Status { get; private set; } = null!;


        /// <summary>
        /// Create a StatefulSetPatch resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StatefulSetPatch(string name, Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1.StatefulSetPatchArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apps/v1beta1:StatefulSetPatch", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal StatefulSetPatch(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apps/v1beta1:StatefulSetPatch", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private StatefulSetPatch(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:apps/v1beta1:StatefulSetPatch", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1.StatefulSetPatchArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1.StatefulSetPatchArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1.StatefulSetPatchArgs();
            args.ApiVersion = "apps/v1beta1";
            args.Kind = "StatefulSet";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new global::Pulumi.Alias { Type = "kubernetes:apps/v1:StatefulSetPatch"},
                    new global::Pulumi.Alias { Type = "kubernetes:apps/v1beta2:StatefulSetPatch"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing StatefulSetPatch resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StatefulSetPatch Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new StatefulSetPatch(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1
{

    public class StatefulSetPatchArgs : global::Pulumi.ResourceArgs
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

        [Input("metadata", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaPatchArgs> Metadata { get; set; } = null!;

        /// <summary>
        /// Spec defines the desired identities of pods in this set.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta1.StatefulSetSpecPatchArgs>? Spec { get; set; }

        public StatefulSetPatchArgs()
        {
        }
        public static new StatefulSetPatchArgs Empty => new StatefulSetPatchArgs();
    }
}
