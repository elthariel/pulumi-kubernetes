// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1
{

    /// <summary>
    /// SupplementalGroupsStrategyOptions defines the strategy type and options used to create the strategy.
    /// </summary>
    public class SupplementalGroupsStrategyOptionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("ranges")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.IDRangeArgs>? _ranges;

        /// <summary>
        /// ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end. Required for MustRunAs.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.IDRangeArgs> Ranges
        {
            get => _ranges ?? (_ranges = new InputList<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.IDRangeArgs>());
            set => _ranges = value;
        }

        /// <summary>
        /// rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.
        /// </summary>
        [Input("rule")]
        public Input<string>? Rule { get; set; }

        public SupplementalGroupsStrategyOptionsArgs()
        {
        }
        public static new SupplementalGroupsStrategyOptionsArgs Empty => new SupplementalGroupsStrategyOptionsArgs();
    }
}
