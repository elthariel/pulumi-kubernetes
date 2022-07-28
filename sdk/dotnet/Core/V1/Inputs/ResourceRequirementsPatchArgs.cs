// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// ResourceRequirements describes the compute resource requirements.
    /// </summary>
    public class ResourceRequirementsPatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputMap<string>? _limits;

        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public InputMap<string> Limits
        {
            get => _limits ?? (_limits = new InputMap<string>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputMap<string>? _requests;

        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public InputMap<string> Requests
        {
            get => _requests ?? (_requests = new InputMap<string>());
            set => _requests = value;
        }

        public ResourceRequirementsPatchArgs()
        {
        }
        public static new ResourceRequirementsPatchArgs Empty => new ResourceRequirementsPatchArgs();
    }
}
