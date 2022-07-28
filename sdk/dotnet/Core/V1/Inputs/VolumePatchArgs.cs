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
    /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
    /// </summary>
    public class VolumePatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AWSElasticBlockStoreVolumeSourcePatchArgs>? AwsElasticBlockStore { get; set; }

        /// <summary>
        /// azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AzureDiskVolumeSourcePatchArgs>? AzureDisk { get; set; }

        /// <summary>
        /// azureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AzureFileVolumeSourcePatchArgs>? AzureFile { get; set; }

        /// <summary>
        /// cephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CephFSVolumeSourcePatchArgs>? Cephfs { get; set; }

        /// <summary>
        /// cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CinderVolumeSourcePatchArgs>? Cinder { get; set; }

        /// <summary>
        /// configMap represents a configMap that should populate this volume
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ConfigMapVolumeSourcePatchArgs>? ConfigMap { get; set; }

        /// <summary>
        /// csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).
        /// </summary>
        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CSIVolumeSourcePatchArgs>? Csi { get; set; }

        /// <summary>
        /// downwardAPI represents downward API about the pod that should populate this volume
        /// </summary>
        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.DownwardAPIVolumeSourcePatchArgs>? DownwardAPI { get; set; }

        /// <summary>
        /// emptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.EmptyDirVolumeSourcePatchArgs>? EmptyDir { get; set; }

        /// <summary>
        /// ephemeral represents a volume that is handled by a cluster storage driver. The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.
        /// 
        /// Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity
        ///    tracking are needed,
        /// c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through
        ///    a PersistentVolumeClaim (see EphemeralVolumeSource for more
        ///    information on the connection between this volume type
        ///    and PersistentVolumeClaim).
        /// 
        /// Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.
        /// 
        /// Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.
        /// 
        /// A pod can use both types of ephemeral volumes and persistent volumes at the same time.
        /// </summary>
        [Input("ephemeral")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.EphemeralVolumeSourcePatchArgs>? Ephemeral { get; set; }

        /// <summary>
        /// fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FCVolumeSourcePatchArgs>? Fc { get; set; }

        /// <summary>
        /// flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.
        /// </summary>
        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FlexVolumeSourcePatchArgs>? FlexVolume { get; set; }

        /// <summary>
        /// flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
        /// </summary>
        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FlockerVolumeSourcePatchArgs>? Flocker { get; set; }

        /// <summary>
        /// gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GCEPersistentDiskVolumeSourcePatchArgs>? GcePersistentDisk { get; set; }

        /// <summary>
        /// gitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        /// </summary>
        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GitRepoVolumeSourcePatchArgs>? GitRepo { get; set; }

        /// <summary>
        /// glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md
        /// </summary>
        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GlusterfsVolumeSourcePatchArgs>? Glusterfs { get; set; }

        /// <summary>
        /// hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.HostPathVolumeSourcePatchArgs>? HostPath { get; set; }

        /// <summary>
        /// iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md
        /// </summary>
        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ISCSIVolumeSourcePatchArgs>? Iscsi { get; set; }

        /// <summary>
        /// name of the volume. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.NFSVolumeSourcePatchArgs>? Nfs { get; set; }

        /// <summary>
        /// persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PersistentVolumeClaimVolumeSourcePatchArgs>? PersistentVolumeClaim { get; set; }

        /// <summary>
        /// photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PhotonPersistentDiskVolumeSourcePatchArgs>? PhotonPersistentDisk { get; set; }

        /// <summary>
        /// portworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PortworxVolumeSourcePatchArgs>? PortworxVolume { get; set; }

        /// <summary>
        /// projected items for all in one resources secrets, configmaps, and downward API
        /// </summary>
        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ProjectedVolumeSourcePatchArgs>? Projected { get; set; }

        /// <summary>
        /// quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.QuobyteVolumeSourcePatchArgs>? Quobyte { get; set; }

        /// <summary>
        /// rbd represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md
        /// </summary>
        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.RBDVolumeSourcePatchArgs>? Rbd { get; set; }

        /// <summary>
        /// scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ScaleIOVolumeSourcePatchArgs>? ScaleIO { get; set; }

        /// <summary>
        /// secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.SecretVolumeSourcePatchArgs>? Secret { get; set; }

        /// <summary>
        /// storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageOSVolumeSourcePatchArgs>? Storageos { get; set; }

        /// <summary>
        /// vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.VsphereVirtualDiskVolumeSourcePatchArgs>? VsphereVolume { get; set; }

        public VolumePatchArgs()
        {
        }
        public static new VolumePatchArgs Empty => new VolumePatchArgs();
    }
}
