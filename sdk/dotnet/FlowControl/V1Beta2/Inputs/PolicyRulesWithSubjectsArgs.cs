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
    /// PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver. The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
    /// </summary>
    public class PolicyRulesWithSubjectsArgs : global::Pulumi.ResourceArgs
    {
        [Input("nonResourceRules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.NonResourcePolicyRuleArgs>? _nonResourceRules;

        /// <summary>
        /// `nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.NonResourcePolicyRuleArgs> NonResourceRules
        {
            get => _nonResourceRules ?? (_nonResourceRules = new InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.NonResourcePolicyRuleArgs>());
            set => _nonResourceRules = value;
        }

        [Input("resourceRules")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.ResourcePolicyRuleArgs>? _resourceRules;

        /// <summary>
        /// `resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource. At least one of `resourceRules` and `nonResourceRules` has to be non-empty.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.ResourcePolicyRuleArgs> ResourceRules
        {
            get => _resourceRules ?? (_resourceRules = new InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.ResourcePolicyRuleArgs>());
            set => _resourceRules = value;
        }

        [Input("subjects", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.SubjectArgs>? _subjects;

        /// <summary>
        /// subjects is the list of normal user, serviceaccount, or group that this rule cares about. There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.SubjectArgs> Subjects
        {
            get => _subjects ?? (_subjects = new InputList<Pulumi.Kubernetes.Types.Inputs.FlowControl.V1Beta2.SubjectArgs>());
            set => _subjects = value;
        }

        public PolicyRulesWithSubjectsArgs()
        {
        }
        public static new PolicyRulesWithSubjectsArgs Empty => new PolicyRulesWithSubjectsArgs();
    }
}
