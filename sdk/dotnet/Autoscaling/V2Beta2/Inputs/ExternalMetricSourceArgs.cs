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
    /// ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
    /// </summary>
    public class ExternalMetricSourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [Input("metric", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2.MetricIdentifierArgs> Metric { get; set; } = null!;

        /// <summary>
        /// target specifies the target value for the given metric
        /// </summary>
        [Input("target", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Autoscaling.V2Beta2.MetricTargetArgs> Target { get; set; } = null!;

        public ExternalMetricSourceArgs()
        {
        }
        public static new ExternalMetricSourceArgs Empty => new ExternalMetricSourceArgs();
    }
}
