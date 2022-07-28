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
    /// PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes
    /// </summary>
    public class PersistentVolumeClaimSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("accessModes")]
        private InputList<string>? _accessModes;

        /// <summary>
        /// accessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        /// </summary>
        public InputList<string> AccessModes
        {
            get => _accessModes ?? (_accessModes = new InputList<string>());
            set => _accessModes = value;
        }

        /// <summary>
        /// dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. If the AnyVolumeDataSource feature gate is enabled, this field will always have the same contents as the DataSourceRef field.
        /// </summary>
        [Input("dataSource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.TypedLocalObjectReferenceArgs>? DataSource { get; set; }

        /// <summary>
        /// dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired. This may be any local object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the DataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, both fields (DataSource and DataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. There are two important differences between DataSource and DataSourceRef: * While DataSource only allows two specific types of objects, DataSourceRef
        ///   allows any non-core object, as well as PersistentVolumeClaim objects.
        /// * While DataSource ignores disallowed values (dropping them), DataSourceRef
        ///   preserves all values, and generates an error if a disallowed value is
        ///   specified.
        /// (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled.
        /// </summary>
        [Input("dataSourceRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.TypedLocalObjectReferenceArgs>? DataSourceRef { get; set; }

        /// <summary>
        /// resources represents the minimum resources the volume should have. If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ResourceRequirementsArgs>? Resources { get; set; }

        /// <summary>
        /// selector is a label query over volumes to consider for binding.
        /// </summary>
        [Input("selector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.LabelSelectorArgs>? Selector { get; set; }

        /// <summary>
        /// storageClassName is the name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1
        /// </summary>
        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        /// <summary>
        /// volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec.
        /// </summary>
        [Input("volumeMode")]
        public Input<string>? VolumeMode { get; set; }

        /// <summary>
        /// volumeName is the binding reference to the PersistentVolume backing this claim.
        /// </summary>
        [Input("volumeName")]
        public Input<string>? VolumeName { get; set; }

        public PersistentVolumeClaimSpecArgs()
        {
        }
        public static new PersistentVolumeClaimSpecArgs Empty => new PersistentVolumeClaimSpecArgs();
    }
}
