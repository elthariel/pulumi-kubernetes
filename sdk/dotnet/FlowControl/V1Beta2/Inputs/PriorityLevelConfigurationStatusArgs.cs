// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2
{

    /// <summary>
    /// PriorityLevelConfigurationStatus represents the current state of a "request-priority".
    /// </summary>
    public class PriorityLevelConfigurationStatusArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.PriorityLevelConfigurationConditionArgs>? _conditions;

        /// <summary>
        /// `conditions` is the current state of "request-priority".
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.PriorityLevelConfigurationConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.PriorityLevelConfigurationConditionArgs>());
            set => _conditions = value;
        }

        public PriorityLevelConfigurationStatusArgs()
        {
        }
        public static new PriorityLevelConfigurationStatusArgs Empty => new PriorityLevelConfigurationStatusArgs();
    }
}
