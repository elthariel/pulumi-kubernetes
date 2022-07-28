// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Coordination.V1Beta1
{

    /// <summary>
    /// LeaseSpec is a specification of a Lease.
    /// </summary>
    public class LeaseSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// acquireTime is a time when the current lease was acquired.
        /// </summary>
        [Input("acquireTime")]
        public Input<string>? AcquireTime { get; set; }

        /// <summary>
        /// holderIdentity contains the identity of the holder of a current lease.
        /// </summary>
        [Input("holderIdentity")]
        public Input<string>? HolderIdentity { get; set; }

        /// <summary>
        /// leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.
        /// </summary>
        [Input("leaseDurationSeconds")]
        public Input<int>? LeaseDurationSeconds { get; set; }

        /// <summary>
        /// leaseTransitions is the number of transitions of a lease between holders.
        /// </summary>
        [Input("leaseTransitions")]
        public Input<int>? LeaseTransitions { get; set; }

        /// <summary>
        /// renewTime is a time when the current holder of a lease has last updated the lease.
        /// </summary>
        [Input("renewTime")]
        public Input<string>? RenewTime { get; set; }

        public LeaseSpecArgs()
        {
        }
        public static new LeaseSpecArgs Empty => new LeaseSpecArgs();
    }
}
