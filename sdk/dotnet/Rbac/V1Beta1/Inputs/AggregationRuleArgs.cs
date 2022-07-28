// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Rbac.V1Beta1
{

    /// <summary>
    /// AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole
    /// </summary>
    public class AggregationRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterRoleSelectors")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.LabelSelectorArgs>? _clusterRoleSelectors;

        /// <summary>
        /// ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.LabelSelectorArgs> ClusterRoleSelectors
        {
            get => _clusterRoleSelectors ?? (_clusterRoleSelectors = new InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.LabelSelectorArgs>());
            set => _clusterRoleSelectors = value;
        }

        public AggregationRuleArgs()
        {
        }
        public static new AggregationRuleArgs Empty => new AggregationRuleArgs();
    }
}
