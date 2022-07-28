// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Certificates.V1
{
    /// <summary>
    /// Patch resources are used to modify existing Kubernetes resources by using
    /// Server-Side Apply updates. The name of the resource must be specified, but all other properties are optional. More than
    /// one patch may be applied to the same resource, and a random FieldManager name will be used for each Patch resource.
    /// Conflicts will result in an error by default, but can be forced using the "pulumi.com/patchForce" annotation. See the
    /// [Server-Side Apply Docs](https://www.pulumi.com/registry/packages/kubernetes/installation-configuration/#server-side-apply) for
    /// additional information about using Server-Side Apply to manage Kubernetes resources with Pulumi.
    /// CertificateSigningRequest objects provide a mechanism to obtain x509 certificates by submitting a certificate signing request, and having it asynchronously approved and issued.
    /// 
    /// Kubelets use this API to obtain:
    ///  1. client certificates to authenticate to kube-apiserver (with the "kubernetes.io/kube-apiserver-client-kubelet" signerName).
    ///  2. serving certificates for TLS endpoints kube-apiserver can connect to securely (with the "kubernetes.io/kubelet-serving" signerName).
    /// 
    /// This API can be used to request client certificates to authenticate to kube-apiserver (with the "kubernetes.io/kube-apiserver-client" signerName), or to obtain certificates from custom non-Kubernetes signers.
    /// </summary>
    [KubernetesResourceType("kubernetes:certificates.k8s.io/v1:CertificateSigningRequestPatch")]
    public partial class CertificateSigningRequestPatch : KubernetesResource
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
        /// spec contains the certificate request, and is immutable after creation. Only the request, signerName, expirationSeconds, and usages fields can be set on creation. Other fields are derived by Kubernetes and cannot be modified by users.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Certificates.V1.CertificateSigningRequestSpecPatch> Spec { get; private set; } = null!;

        /// <summary>
        /// status contains information about whether the request is approved or denied, and the certificate issued by the signer, or the failure condition indicating signer failure.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Certificates.V1.CertificateSigningRequestStatusPatch> Status { get; private set; } = null!;


        /// <summary>
        /// Create a CertificateSigningRequestPatch resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CertificateSigningRequestPatch(string name, Pulumi.Kubernetes.Types.Inputs.Certificates.V1.CertificateSigningRequestPatchArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:certificates.k8s.io/v1:CertificateSigningRequestPatch", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal CertificateSigningRequestPatch(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:certificates.k8s.io/v1:CertificateSigningRequestPatch", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private CertificateSigningRequestPatch(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:certificates.k8s.io/v1:CertificateSigningRequestPatch", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Certificates.V1.CertificateSigningRequestPatchArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Certificates.V1.CertificateSigningRequestPatchArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Certificates.V1.CertificateSigningRequestPatchArgs();
            args.ApiVersion = "certificates.k8s.io/v1";
            args.Kind = "CertificateSigningRequest";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new global::Pulumi.Alias { Type = "kubernetes:certificates.k8s.io/v1beta1:CertificateSigningRequestPatch"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CertificateSigningRequestPatch resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CertificateSigningRequestPatch Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CertificateSigningRequestPatch(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Certificates.V1
{

    public class CertificateSigningRequestPatchArgs : global::Pulumi.ResourceArgs
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
        /// spec contains the certificate request, and is immutable after creation. Only the request, signerName, expirationSeconds, and usages fields can be set on creation. Other fields are derived by Kubernetes and cannot be modified by users.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certificates.V1.CertificateSigningRequestSpecPatchArgs>? Spec { get; set; }

        public CertificateSigningRequestPatchArgs()
        {
        }
        public static new CertificateSigningRequestPatchArgs Empty => new CertificateSigningRequestPatchArgs();
    }
}
