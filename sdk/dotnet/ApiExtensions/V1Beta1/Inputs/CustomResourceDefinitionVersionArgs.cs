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
    /// CustomResourceDefinitionVersion describes a version for CRD.
    /// </summary>
    public class CustomResourceDefinitionVersionArgs : global::Pulumi.ResourceArgs
    {
        [Input("additionalPrinterColumns")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.CustomResourceColumnDefinitionArgs>? _additionalPrinterColumns;

        /// <summary>
        /// additionalPrinterColumns specifies additional columns returned in Table output. See https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables for details. Top-level and per-version columns are mutually exclusive. Per-version columns must not all be set to identical values (top-level columns should be used instead). If no top-level or per-version columns are specified, a single column displaying the age of the custom resource is used.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.CustomResourceColumnDefinitionArgs> AdditionalPrinterColumns
        {
            get => _additionalPrinterColumns ?? (_additionalPrinterColumns = new InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.CustomResourceColumnDefinitionArgs>());
            set => _additionalPrinterColumns = value;
        }

        /// <summary>
        /// deprecated indicates this version of the custom resource API is deprecated. When set to true, API requests to this version receive a warning header in the server response. Defaults to false.
        /// </summary>
        [Input("deprecated")]
        public Input<bool>? Deprecated { get; set; }

        /// <summary>
        /// deprecationWarning overrides the default warning returned to API clients. May only be set when `deprecated` is true. The default warning indicates this version is deprecated and recommends use of the newest served version of equal or greater stability, if one exists.
        /// </summary>
        [Input("deprecationWarning")]
        public Input<string>? DeprecationWarning { get; set; }

        /// <summary>
        /// name is the version name, e.g. “v1”, “v2beta1”, etc. The custom resources are served under this version at `/apis/&lt;group&gt;/&lt;version&gt;/...` if `served` is true.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// schema describes the schema used for validation and pruning of this version of the custom resource. Top-level and per-version schemas are mutually exclusive. Per-version schemas must not all be set to identical values (top-level validation schema should be used instead).
        /// </summary>
        [Input("schema")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.CustomResourceValidationArgs>? Schema { get; set; }

        /// <summary>
        /// served is a flag enabling/disabling this version from being served via REST APIs
        /// </summary>
        [Input("served", required: true)]
        public Input<bool> Served { get; set; } = null!;

        /// <summary>
        /// storage indicates this version should be used when persisting custom resources to storage. There must be exactly one version with storage=true.
        /// </summary>
        [Input("storage", required: true)]
        public Input<bool> Storage { get; set; } = null!;

        /// <summary>
        /// subresources specify what subresources this version of the defined custom resource have. Top-level and per-version subresources are mutually exclusive. Per-version subresources must not all be set to identical values (top-level subresources should be used instead).
        /// </summary>
        [Input("subresources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.CustomResourceSubresourcesArgs>? Subresources { get; set; }

        public CustomResourceDefinitionVersionArgs()
        {
        }
        public static new CustomResourceDefinitionVersionArgs Empty => new CustomResourceDefinitionVersionArgs();
    }
}
