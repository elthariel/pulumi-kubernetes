// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2
{

    /// <summary>
    /// HPAScalingPolicy is a single policy which must hold true for a specified past interval.
    /// </summary>
    public class HPAScalingPolicyPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// PeriodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
        /// </summary>
        [Input("periodSeconds")]
        public Input<int>? PeriodSeconds { get; set; }

        /// <summary>
        /// Type is used to specify the scaling policy.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Value contains the amount of change which is permitted by the policy. It must be greater than zero
        /// </summary>
        [Input("value")]
        public Input<int>? Value { get; set; }

        public HPAScalingPolicyPatchArgs()
        {
        }
        public static new HPAScalingPolicyPatchArgs Empty => new HPAScalingPolicyPatchArgs();
    }
}
