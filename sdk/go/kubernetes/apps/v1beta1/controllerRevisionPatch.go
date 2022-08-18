// Code generated by pulumigen DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Patch resources are used to modify existing Kubernetes resources by using
// Server-Side Apply updates. The name of the resource must be specified, but all other properties are optional. More than
// one patch may be applied to the same resource, and a random FieldManager name will be used for each Patch resource.
// Conflicts will result in an error by default, but can be forced using the "pulumi.com/patchForce" annotation. See the
// [Server-Side Apply Docs](https://www.pulumi.com/registry/packages/kubernetes/installation-configuration/#server-side-apply) for
// additional information about using Server-Side Apply to manage Kubernetes resources with Pulumi.
// ControllerRevision implements an immutable snapshot of state data. Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.
//
// Deprecated: apps/v1beta1/ControllerRevision is deprecated by apps/v1/ControllerRevision and not supported by Kubernetes v1.16+ clusters.
type ControllerRevisionPatch struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Data is the serialized representation of the state.
	Data pulumi.AnyOutput `pulumi:"data"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ObjectMetaPatchPtrOutput `pulumi:"metadata"`
	// Revision indicates the revision of the state represented by Data.
	Revision pulumi.IntPtrOutput `pulumi:"revision"`
}

// NewControllerRevisionPatch registers a new resource with the given unique name, arguments, and options.
func NewControllerRevisionPatch(ctx *pulumi.Context,
	name string, args *ControllerRevisionPatchArgs, opts ...pulumi.ResourceOption) (*ControllerRevisionPatch, error) {
	if args == nil {
		args = &ControllerRevisionPatchArgs{}
	}

	args.ApiVersion = pulumi.StringPtr("apps/v1beta1")
	args.Kind = pulumi.StringPtr("ControllerRevision")
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("kubernetes:apps/v1:ControllerRevisionPatch"),
		},
		{
			Type: pulumi.String("kubernetes:apps/v1beta2:ControllerRevisionPatch"),
		},
	})
	opts = append(opts, aliases)
	var resource ControllerRevisionPatch
	err := ctx.RegisterResource("kubernetes:apps/v1beta1:ControllerRevisionPatch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetControllerRevisionPatch gets an existing ControllerRevisionPatch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetControllerRevisionPatch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ControllerRevisionPatchState, opts ...pulumi.ResourceOption) (*ControllerRevisionPatch, error) {
	var resource ControllerRevisionPatch
	err := ctx.ReadResource("kubernetes:apps/v1beta1:ControllerRevisionPatch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ControllerRevisionPatch resources.
type controllerRevisionPatchState struct {
}

type ControllerRevisionPatchState struct {
}

func (ControllerRevisionPatchState) ElementType() reflect.Type {
	return reflect.TypeOf((*controllerRevisionPatchState)(nil)).Elem()
}

type controllerRevisionPatchArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Data is the serialized representation of the state.
	Data interface{} `pulumi:"data"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata *metav1.ObjectMetaPatch `pulumi:"metadata"`
	// Revision indicates the revision of the state represented by Data.
	Revision *int `pulumi:"revision"`
}

// The set of arguments for constructing a ControllerRevisionPatch resource.
type ControllerRevisionPatchArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Data is the serialized representation of the state.
	Data pulumi.Input
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput
	// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ObjectMetaPatchPtrInput
	// Revision indicates the revision of the state represented by Data.
	Revision pulumi.IntPtrInput
}

func (ControllerRevisionPatchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*controllerRevisionPatchArgs)(nil)).Elem()
}

type ControllerRevisionPatchInput interface {
	pulumi.Input

	ToControllerRevisionPatchOutput() ControllerRevisionPatchOutput
	ToControllerRevisionPatchOutputWithContext(ctx context.Context) ControllerRevisionPatchOutput
}

func (*ControllerRevisionPatch) ElementType() reflect.Type {
	return reflect.TypeOf((**ControllerRevisionPatch)(nil)).Elem()
}

func (i *ControllerRevisionPatch) ToControllerRevisionPatchOutput() ControllerRevisionPatchOutput {
	return i.ToControllerRevisionPatchOutputWithContext(context.Background())
}

func (i *ControllerRevisionPatch) ToControllerRevisionPatchOutputWithContext(ctx context.Context) ControllerRevisionPatchOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ControllerRevisionPatchOutput)
}

// ControllerRevisionPatchArrayInput is an input type that accepts ControllerRevisionPatchArray and ControllerRevisionPatchArrayOutput values.
// You can construct a concrete instance of `ControllerRevisionPatchArrayInput` via:
//
//	ControllerRevisionPatchArray{ ControllerRevisionPatchArgs{...} }
type ControllerRevisionPatchArrayInput interface {
	pulumi.Input

	ToControllerRevisionPatchArrayOutput() ControllerRevisionPatchArrayOutput
	ToControllerRevisionPatchArrayOutputWithContext(context.Context) ControllerRevisionPatchArrayOutput
}

type ControllerRevisionPatchArray []ControllerRevisionPatchInput

func (ControllerRevisionPatchArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ControllerRevisionPatch)(nil)).Elem()
}

func (i ControllerRevisionPatchArray) ToControllerRevisionPatchArrayOutput() ControllerRevisionPatchArrayOutput {
	return i.ToControllerRevisionPatchArrayOutputWithContext(context.Background())
}

func (i ControllerRevisionPatchArray) ToControllerRevisionPatchArrayOutputWithContext(ctx context.Context) ControllerRevisionPatchArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ControllerRevisionPatchArrayOutput)
}

// ControllerRevisionPatchMapInput is an input type that accepts ControllerRevisionPatchMap and ControllerRevisionPatchMapOutput values.
// You can construct a concrete instance of `ControllerRevisionPatchMapInput` via:
//
//	ControllerRevisionPatchMap{ "key": ControllerRevisionPatchArgs{...} }
type ControllerRevisionPatchMapInput interface {
	pulumi.Input

	ToControllerRevisionPatchMapOutput() ControllerRevisionPatchMapOutput
	ToControllerRevisionPatchMapOutputWithContext(context.Context) ControllerRevisionPatchMapOutput
}

type ControllerRevisionPatchMap map[string]ControllerRevisionPatchInput

func (ControllerRevisionPatchMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ControllerRevisionPatch)(nil)).Elem()
}

func (i ControllerRevisionPatchMap) ToControllerRevisionPatchMapOutput() ControllerRevisionPatchMapOutput {
	return i.ToControllerRevisionPatchMapOutputWithContext(context.Background())
}

func (i ControllerRevisionPatchMap) ToControllerRevisionPatchMapOutputWithContext(ctx context.Context) ControllerRevisionPatchMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ControllerRevisionPatchMapOutput)
}

type ControllerRevisionPatchOutput struct{ *pulumi.OutputState }

func (ControllerRevisionPatchOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ControllerRevisionPatch)(nil)).Elem()
}

func (o ControllerRevisionPatchOutput) ToControllerRevisionPatchOutput() ControllerRevisionPatchOutput {
	return o
}

func (o ControllerRevisionPatchOutput) ToControllerRevisionPatchOutputWithContext(ctx context.Context) ControllerRevisionPatchOutput {
	return o
}

// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
func (o ControllerRevisionPatchOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ControllerRevisionPatch) pulumi.StringPtrOutput { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

// Data is the serialized representation of the state.
func (o ControllerRevisionPatchOutput) Data() pulumi.AnyOutput {
	return o.ApplyT(func(v *ControllerRevisionPatch) pulumi.AnyOutput { return v.Data }).(pulumi.AnyOutput)
}

// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o ControllerRevisionPatchOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ControllerRevisionPatch) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
func (o ControllerRevisionPatchOutput) Metadata() metav1.ObjectMetaPatchPtrOutput {
	return o.ApplyT(func(v *ControllerRevisionPatch) metav1.ObjectMetaPatchPtrOutput { return v.Metadata }).(metav1.ObjectMetaPatchPtrOutput)
}

// Revision indicates the revision of the state represented by Data.
func (o ControllerRevisionPatchOutput) Revision() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ControllerRevisionPatch) pulumi.IntPtrOutput { return v.Revision }).(pulumi.IntPtrOutput)
}

type ControllerRevisionPatchArrayOutput struct{ *pulumi.OutputState }

func (ControllerRevisionPatchArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ControllerRevisionPatch)(nil)).Elem()
}

func (o ControllerRevisionPatchArrayOutput) ToControllerRevisionPatchArrayOutput() ControllerRevisionPatchArrayOutput {
	return o
}

func (o ControllerRevisionPatchArrayOutput) ToControllerRevisionPatchArrayOutputWithContext(ctx context.Context) ControllerRevisionPatchArrayOutput {
	return o
}

func (o ControllerRevisionPatchArrayOutput) Index(i pulumi.IntInput) ControllerRevisionPatchOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ControllerRevisionPatch {
		return vs[0].([]*ControllerRevisionPatch)[vs[1].(int)]
	}).(ControllerRevisionPatchOutput)
}

type ControllerRevisionPatchMapOutput struct{ *pulumi.OutputState }

func (ControllerRevisionPatchMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ControllerRevisionPatch)(nil)).Elem()
}

func (o ControllerRevisionPatchMapOutput) ToControllerRevisionPatchMapOutput() ControllerRevisionPatchMapOutput {
	return o
}

func (o ControllerRevisionPatchMapOutput) ToControllerRevisionPatchMapOutputWithContext(ctx context.Context) ControllerRevisionPatchMapOutput {
	return o
}

func (o ControllerRevisionPatchMapOutput) MapIndex(k pulumi.StringInput) ControllerRevisionPatchOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ControllerRevisionPatch {
		return vs[0].(map[string]*ControllerRevisionPatch)[vs[1].(string)]
	}).(ControllerRevisionPatchOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ControllerRevisionPatchInput)(nil)).Elem(), &ControllerRevisionPatch{})
	pulumi.RegisterInputType(reflect.TypeOf((*ControllerRevisionPatchArrayInput)(nil)).Elem(), ControllerRevisionPatchArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ControllerRevisionPatchMapInput)(nil)).Elem(), ControllerRevisionPatchMap{})
	pulumi.RegisterOutputType(ControllerRevisionPatchOutput{})
	pulumi.RegisterOutputType(ControllerRevisionPatchArrayOutput{})
	pulumi.RegisterOutputType(ControllerRevisionPatchMapOutput{})
}
