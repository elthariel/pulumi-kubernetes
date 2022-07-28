// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1
{

    /// <summary>
    /// DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.
    /// </summary>
    public class DaemonSetUpdateStrategyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rolling update config params. Present only if type = "RollingUpdate".
        /// </summary>
        [Input("rollingUpdate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1.RollingUpdateDaemonSetArgs>? RollingUpdate { get; set; }

        /// <summary>
        /// Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public DaemonSetUpdateStrategyArgs()
        {
        }
        public static new DaemonSetUpdateStrategyArgs Empty => new DaemonSetUpdateStrategyArgs();
    }
}
