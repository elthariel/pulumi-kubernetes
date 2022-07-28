// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1
{

    /// <summary>
    /// DeploymentStrategy describes how to replace existing pods with new ones.
    /// </summary>
    public class DeploymentStrategyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
        /// </summary>
        [Input("rollingUpdate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Extensions.V1Beta1.RollingUpdateDeploymentArgs>? RollingUpdate { get; set; }

        /// <summary>
        /// Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public DeploymentStrategyArgs()
        {
        }
        public static new DeploymentStrategyArgs Empty => new DeploymentStrategyArgs();
    }
}
