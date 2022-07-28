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
    /// LimitRangeSpec defines a min/max usage limit for resources that match on kind.
    /// </summary>
    public class LimitRangeSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("limits", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LimitRangeItemArgs>? _limits;

        /// <summary>
        /// Limits is the list of LimitRangeItem objects that are enforced.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LimitRangeItemArgs> Limits
        {
            get => _limits ?? (_limits = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LimitRangeItemArgs>());
            set => _limits = value;
        }

        public LimitRangeSpecArgs()
        {
        }
        public static new LimitRangeSpecArgs Empty => new LimitRangeSpecArgs();
    }
}
