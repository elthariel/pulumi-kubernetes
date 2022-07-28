// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Batch.V2Alpha1
{

    /// <summary>
    /// CronJobSpec describes how the job execution will look like and when it will actually run.
    /// </summary>
    public class CronJobSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one
        /// </summary>
        [Input("concurrencyPolicy")]
        public Input<string>? ConcurrencyPolicy { get; set; }

        /// <summary>
        /// The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [Input("failedJobsHistoryLimit")]
        public Input<int>? FailedJobsHistoryLimit { get; set; }

        /// <summary>
        /// Specifies the job that will be created when executing a CronJob.
        /// </summary>
        [Input("jobTemplate", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Batch.V2Alpha1.JobTemplateSpecArgs> JobTemplate { get; set; } = null!;

        /// <summary>
        /// The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
        /// </summary>
        [Input("schedule", required: true)]
        public Input<string> Schedule { get; set; } = null!;

        /// <summary>
        /// Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
        /// </summary>
        [Input("startingDeadlineSeconds")]
        public Input<int>? StartingDeadlineSeconds { get; set; }

        /// <summary>
        /// The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [Input("successfulJobsHistoryLimit")]
        public Input<int>? SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>
        /// This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
        /// </summary>
        [Input("suspend")]
        public Input<bool>? Suspend { get; set; }

        public CronJobSpecArgs()
        {
        }
        public static new CronJobSpecArgs Empty => new CronJobSpecArgs();
    }
}
