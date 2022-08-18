// Code generated by pulumigen DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ValidatingWebhookConfigurationList is a list of ValidatingWebhookConfiguration.
type ValidatingWebhookConfigurationList struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// List of ValidatingWebhookConfiguration.
	Items ValidatingWebhookConfigurationTypeArrayOutput `pulumi:"items"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Metadata metav1.ListMetaPtrOutput `pulumi:"metadata"`
}

// NewValidatingWebhookConfigurationList registers a new resource with the given unique name, arguments, and options.
func NewValidatingWebhookConfigurationList(ctx *pulumi.Context,
	name string, args *ValidatingWebhookConfigurationListArgs, opts ...pulumi.ResourceOption) (*ValidatingWebhookConfigurationList, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Items == nil {
		return nil, errors.New("invalid value for required argument 'Items'")
	}
	args.ApiVersion = pulumi.StringPtr("admissionregistration.k8s.io/v1")
	args.Kind = pulumi.StringPtr("ValidatingWebhookConfigurationList")
	var resource ValidatingWebhookConfigurationList
	err := ctx.RegisterResource("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfigurationList", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetValidatingWebhookConfigurationList gets an existing ValidatingWebhookConfigurationList resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetValidatingWebhookConfigurationList(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ValidatingWebhookConfigurationListState, opts ...pulumi.ResourceOption) (*ValidatingWebhookConfigurationList, error) {
	var resource ValidatingWebhookConfigurationList
	err := ctx.ReadResource("kubernetes:admissionregistration.k8s.io/v1:ValidatingWebhookConfigurationList", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ValidatingWebhookConfigurationList resources.
type validatingWebhookConfigurationListState struct {
}

type ValidatingWebhookConfigurationListState struct {
}

func (ValidatingWebhookConfigurationListState) ElementType() reflect.Type {
	return reflect.TypeOf((*validatingWebhookConfigurationListState)(nil)).Elem()
}

type validatingWebhookConfigurationListArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// List of ValidatingWebhookConfiguration.
	Items []ValidatingWebhookConfigurationType `pulumi:"items"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Metadata *metav1.ListMeta `pulumi:"metadata"`
}

// The set of arguments for constructing a ValidatingWebhookConfigurationList resource.
type ValidatingWebhookConfigurationListArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// List of ValidatingWebhookConfiguration.
	Items ValidatingWebhookConfigurationTypeArrayInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput
	// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Metadata metav1.ListMetaPtrInput
}

func (ValidatingWebhookConfigurationListArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*validatingWebhookConfigurationListArgs)(nil)).Elem()
}

type ValidatingWebhookConfigurationListInput interface {
	pulumi.Input

	ToValidatingWebhookConfigurationListOutput() ValidatingWebhookConfigurationListOutput
	ToValidatingWebhookConfigurationListOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListOutput
}

func (*ValidatingWebhookConfigurationList) ElementType() reflect.Type {
	return reflect.TypeOf((**ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (i *ValidatingWebhookConfigurationList) ToValidatingWebhookConfigurationListOutput() ValidatingWebhookConfigurationListOutput {
	return i.ToValidatingWebhookConfigurationListOutputWithContext(context.Background())
}

func (i *ValidatingWebhookConfigurationList) ToValidatingWebhookConfigurationListOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ValidatingWebhookConfigurationListOutput)
}

// ValidatingWebhookConfigurationListArrayInput is an input type that accepts ValidatingWebhookConfigurationListArray and ValidatingWebhookConfigurationListArrayOutput values.
// You can construct a concrete instance of `ValidatingWebhookConfigurationListArrayInput` via:
//
//	ValidatingWebhookConfigurationListArray{ ValidatingWebhookConfigurationListArgs{...} }
type ValidatingWebhookConfigurationListArrayInput interface {
	pulumi.Input

	ToValidatingWebhookConfigurationListArrayOutput() ValidatingWebhookConfigurationListArrayOutput
	ToValidatingWebhookConfigurationListArrayOutputWithContext(context.Context) ValidatingWebhookConfigurationListArrayOutput
}

type ValidatingWebhookConfigurationListArray []ValidatingWebhookConfigurationListInput

func (ValidatingWebhookConfigurationListArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (i ValidatingWebhookConfigurationListArray) ToValidatingWebhookConfigurationListArrayOutput() ValidatingWebhookConfigurationListArrayOutput {
	return i.ToValidatingWebhookConfigurationListArrayOutputWithContext(context.Background())
}

func (i ValidatingWebhookConfigurationListArray) ToValidatingWebhookConfigurationListArrayOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ValidatingWebhookConfigurationListArrayOutput)
}

// ValidatingWebhookConfigurationListMapInput is an input type that accepts ValidatingWebhookConfigurationListMap and ValidatingWebhookConfigurationListMapOutput values.
// You can construct a concrete instance of `ValidatingWebhookConfigurationListMapInput` via:
//
//	ValidatingWebhookConfigurationListMap{ "key": ValidatingWebhookConfigurationListArgs{...} }
type ValidatingWebhookConfigurationListMapInput interface {
	pulumi.Input

	ToValidatingWebhookConfigurationListMapOutput() ValidatingWebhookConfigurationListMapOutput
	ToValidatingWebhookConfigurationListMapOutputWithContext(context.Context) ValidatingWebhookConfigurationListMapOutput
}

type ValidatingWebhookConfigurationListMap map[string]ValidatingWebhookConfigurationListInput

func (ValidatingWebhookConfigurationListMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (i ValidatingWebhookConfigurationListMap) ToValidatingWebhookConfigurationListMapOutput() ValidatingWebhookConfigurationListMapOutput {
	return i.ToValidatingWebhookConfigurationListMapOutputWithContext(context.Background())
}

func (i ValidatingWebhookConfigurationListMap) ToValidatingWebhookConfigurationListMapOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ValidatingWebhookConfigurationListMapOutput)
}

type ValidatingWebhookConfigurationListOutput struct{ *pulumi.OutputState }

func (ValidatingWebhookConfigurationListOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (o ValidatingWebhookConfigurationListOutput) ToValidatingWebhookConfigurationListOutput() ValidatingWebhookConfigurationListOutput {
	return o
}

func (o ValidatingWebhookConfigurationListOutput) ToValidatingWebhookConfigurationListOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListOutput {
	return o
}

// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
func (o ValidatingWebhookConfigurationListOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ValidatingWebhookConfigurationList) pulumi.StringPtrOutput { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

// List of ValidatingWebhookConfiguration.
func (o ValidatingWebhookConfigurationListOutput) Items() ValidatingWebhookConfigurationTypeArrayOutput {
	return o.ApplyT(func(v *ValidatingWebhookConfigurationList) ValidatingWebhookConfigurationTypeArrayOutput {
		return v.Items
	}).(ValidatingWebhookConfigurationTypeArrayOutput)
}

// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o ValidatingWebhookConfigurationListOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ValidatingWebhookConfigurationList) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o ValidatingWebhookConfigurationListOutput) Metadata() metav1.ListMetaPtrOutput {
	return o.ApplyT(func(v *ValidatingWebhookConfigurationList) metav1.ListMetaPtrOutput { return v.Metadata }).(metav1.ListMetaPtrOutput)
}

type ValidatingWebhookConfigurationListArrayOutput struct{ *pulumi.OutputState }

func (ValidatingWebhookConfigurationListArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (o ValidatingWebhookConfigurationListArrayOutput) ToValidatingWebhookConfigurationListArrayOutput() ValidatingWebhookConfigurationListArrayOutput {
	return o
}

func (o ValidatingWebhookConfigurationListArrayOutput) ToValidatingWebhookConfigurationListArrayOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListArrayOutput {
	return o
}

func (o ValidatingWebhookConfigurationListArrayOutput) Index(i pulumi.IntInput) ValidatingWebhookConfigurationListOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ValidatingWebhookConfigurationList {
		return vs[0].([]*ValidatingWebhookConfigurationList)[vs[1].(int)]
	}).(ValidatingWebhookConfigurationListOutput)
}

type ValidatingWebhookConfigurationListMapOutput struct{ *pulumi.OutputState }

func (ValidatingWebhookConfigurationListMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ValidatingWebhookConfigurationList)(nil)).Elem()
}

func (o ValidatingWebhookConfigurationListMapOutput) ToValidatingWebhookConfigurationListMapOutput() ValidatingWebhookConfigurationListMapOutput {
	return o
}

func (o ValidatingWebhookConfigurationListMapOutput) ToValidatingWebhookConfigurationListMapOutputWithContext(ctx context.Context) ValidatingWebhookConfigurationListMapOutput {
	return o
}

func (o ValidatingWebhookConfigurationListMapOutput) MapIndex(k pulumi.StringInput) ValidatingWebhookConfigurationListOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ValidatingWebhookConfigurationList {
		return vs[0].(map[string]*ValidatingWebhookConfigurationList)[vs[1].(string)]
	}).(ValidatingWebhookConfigurationListOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ValidatingWebhookConfigurationListInput)(nil)).Elem(), &ValidatingWebhookConfigurationList{})
	pulumi.RegisterInputType(reflect.TypeOf((*ValidatingWebhookConfigurationListArrayInput)(nil)).Elem(), ValidatingWebhookConfigurationListArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ValidatingWebhookConfigurationListMapInput)(nil)).Elem(), ValidatingWebhookConfigurationListMap{})
	pulumi.RegisterOutputType(ValidatingWebhookConfigurationListOutput{})
	pulumi.RegisterOutputType(ValidatingWebhookConfigurationListArrayOutput{})
	pulumi.RegisterOutputType(ValidatingWebhookConfigurationListMapOutput{})
}
