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
    /// Adds and removes POSIX capabilities from running containers.
    /// </summary>
    public class CapabilitiesArgs : global::Pulumi.ResourceArgs
    {
        [Input("add")]
        private InputList<string>? _add;

        /// <summary>
        /// Added capabilities
        /// </summary>
        public InputList<string> Add
        {
            get => _add ?? (_add = new InputList<string>());
            set => _add = value;
        }

        [Input("drop")]
        private InputList<string>? _drop;

        /// <summary>
        /// Removed capabilities
        /// </summary>
        public InputList<string> Drop
        {
            get => _drop ?? (_drop = new InputList<string>());
            set => _drop = value;
        }

        public CapabilitiesArgs()
        {
        }
        public static new CapabilitiesArgs Empty => new CapabilitiesArgs();
    }
}
