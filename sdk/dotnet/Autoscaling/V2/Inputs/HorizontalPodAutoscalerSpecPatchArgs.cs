// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2
{

    /// <summary>
    /// HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.
    /// </summary>
    public class HorizontalPodAutoscalerSpecPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// behavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively). If not set, the default HPAScalingRules for scale up and scale down are used.
        /// </summary>
        [Input("behavior")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2.HorizontalPodAutoscalerBehaviorPatchArgs>? Behavior { get; set; }

        /// <summary>
        /// maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.
        /// </summary>
        [Input("maxReplicas")]
        public Input<int>? MaxReplicas { get; set; }

        [Input("metrics")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2.MetricSpecPatchArgs>? _metrics;

        /// <summary>
        /// metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond. If not set, the default metric will be set to 80% average CPU utilization.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2.MetricSpecPatchArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2.MetricSpecPatchArgs>());
            set => _metrics = value;
        }

        /// <summary>
        /// minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
        /// </summary>
        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        /// <summary>
        /// scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.
        /// </summary>
        [Input("scaleTargetRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2.CrossVersionObjectReferencePatchArgs>? ScaleTargetRef { get; set; }

        public HorizontalPodAutoscalerSpecPatchArgs()
        {
        }
        public static new HorizontalPodAutoscalerSpecPatchArgs Empty => new HorizontalPodAutoscalerSpecPatchArgs();
    }
}
