// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta2
{

    /// <summary>
    /// ReplicaSetStatus represents the current status of a ReplicaSet.
    /// </summary>
    public class ReplicaSetStatusArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of available replicas (ready for at least minReadySeconds) for this replica set.
        /// </summary>
        [Input("availableReplicas")]
        public Input<int>? AvailableReplicas { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta2.ReplicaSetConditionArgs>? _conditions;

        /// <summary>
        /// Represents the latest available observations of a replica set's current state.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta2.ReplicaSetConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta2.ReplicaSetConditionArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The number of pods that have labels matching the labels of the pod template of the replicaset.
        /// </summary>
        [Input("fullyLabeledReplicas")]
        public Input<int>? FullyLabeledReplicas { get; set; }

        /// <summary>
        /// ObservedGeneration reflects the generation of the most recently observed ReplicaSet.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        /// <summary>
        /// The number of ready replicas for this replica set.
        /// </summary>
        [Input("readyReplicas")]
        public Input<int>? ReadyReplicas { get; set; }

        /// <summary>
        /// Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        /// </summary>
        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        public ReplicaSetStatusArgs()
        {
        }
        public static new ReplicaSetStatusArgs Empty => new ReplicaSetStatusArgs();
    }
}
