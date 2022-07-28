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
    /// SessionAffinityConfig represents the configurations of session affinity.
    /// </summary>
    public class SessionAffinityConfigPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// clientIP contains the configurations of Client IP based session affinity.
        /// </summary>
        [Input("clientIP")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ClientIPConfigPatchArgs>? ClientIP { get; set; }

        public SessionAffinityConfigPatchArgs()
        {
        }
        public static new SessionAffinityConfigPatchArgs Empty => new SessionAffinityConfigPatchArgs();
    }
}
