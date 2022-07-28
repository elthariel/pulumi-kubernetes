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
    /// A StatefulSetSpec is the specification of a StatefulSet.
    /// </summary>
    public class StatefulSetSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.
        /// </summary>
        [Input("podManagementPolicy")]
        public Input<string>? PodManagementPolicy { get; set; }

        /// <summary>
        /// replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        /// <summary>
        /// revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.
        /// </summary>
        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        /// <summary>
        /// selector is a label query over pods that should match the replica count. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        [Input("selector", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.LabelSelectorArgs> Selector { get; set; } = null!;

        /// <summary>
        /// serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where "pod-specific-string" is managed by the StatefulSet controller.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.
        /// </summary>
        [Input("template", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodTemplateSpecArgs> Template { get; set; } = null!;

        /// <summary>
        /// updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.
        /// </summary>
        [Input("updateStrategy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Beta2.StatefulSetUpdateStrategyArgs>? UpdateStrategy { get; set; }

        [Input("volumeClaimTemplates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PersistentVolumeClaimArgs>? _volumeClaimTemplates;

        /// <summary>
        /// volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PersistentVolumeClaimArgs> VolumeClaimTemplates
        {
            get => _volumeClaimTemplates ?? (_volumeClaimTemplates = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PersistentVolumeClaimArgs>());
            set => _volumeClaimTemplates = value;
        }

        public StatefulSetSpecArgs()
        {
        }
        public static new StatefulSetSpecArgs Empty => new StatefulSetSpecArgs();
    }
}
