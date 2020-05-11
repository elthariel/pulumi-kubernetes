// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	corev1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/core/v1"
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Event is a report of an event somewhere in the cluster. It generally denotes some state change in the system.
type EventType struct {
	// What action was taken/failed regarding to the regarding object.
	Action *string `pulumi:"action"`
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedCount *int `pulumi:"deprecatedCount"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedFirstTimestamp *string `pulumi:"deprecatedFirstTimestamp"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedLastTimestamp *string `pulumi:"deprecatedLastTimestamp"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedSource *corev1.EventSource `pulumi:"deprecatedSource"`
	// Required. Time when this Event was first observed.
	EventTime string `pulumi:"eventTime"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Optional. A human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
	Note *string `pulumi:"note"`
	// Why the action was taken.
	Reason *string `pulumi:"reason"`
	// The object this Event is about. In most cases it's an Object reporting controller implements. E.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
	Regarding *corev1.ObjectReference `pulumi:"regarding"`
	// Optional secondary object for more complex actions. E.g. when regarding object triggers a creation or deletion of related object.
	Related *corev1.ObjectReference `pulumi:"related"`
	// Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.
	ReportingController *string `pulumi:"reportingController"`
	// ID of the controller instance, e.g. `kubelet-xyzf`.
	ReportingInstance *string `pulumi:"reportingInstance"`
	// Data about the Event series this event represents or nil if it's a singleton Event.
	Series *EventSeries `pulumi:"series"`
	// Type of this event (Normal, Warning), new types could be added in the future.
	Type *string `pulumi:"type"`
}

// EventTypeInput is an input type that accepts EventTypeArgs and EventTypeOutput values.
// You can construct a concrete instance of `EventTypeInput` via:
//
// 		 EventTypeArgs{...}
//
type EventTypeInput interface {
	pulumi.Input

	ToEventTypeOutput() EventTypeOutput
	ToEventTypeOutputWithContext(context.Context) EventTypeOutput
}

// Event is a report of an event somewhere in the cluster. It generally denotes some state change in the system.
type EventTypeArgs struct {
	// What action was taken/failed regarding to the regarding object.
	Action pulumi.StringPtrInput `pulumi:"action"`
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput `pulumi:"apiVersion"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedCount pulumi.IntPtrInput `pulumi:"deprecatedCount"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedFirstTimestamp pulumi.StringPtrInput `pulumi:"deprecatedFirstTimestamp"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedLastTimestamp pulumi.StringPtrInput `pulumi:"deprecatedLastTimestamp"`
	// Deprecated field assuring backward compatibility with core.v1 Event type
	DeprecatedSource corev1.EventSourcePtrInput `pulumi:"deprecatedSource"`
	// Required. Time when this Event was first observed.
	EventTime pulumi.StringInput `pulumi:"eventTime"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrInput     `pulumi:"kind"`
	Metadata metav1.ObjectMetaPtrInput `pulumi:"metadata"`
	// Optional. A human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
	Note pulumi.StringPtrInput `pulumi:"note"`
	// Why the action was taken.
	Reason pulumi.StringPtrInput `pulumi:"reason"`
	// The object this Event is about. In most cases it's an Object reporting controller implements. E.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
	Regarding corev1.ObjectReferencePtrInput `pulumi:"regarding"`
	// Optional secondary object for more complex actions. E.g. when regarding object triggers a creation or deletion of related object.
	Related corev1.ObjectReferencePtrInput `pulumi:"related"`
	// Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.
	ReportingController pulumi.StringPtrInput `pulumi:"reportingController"`
	// ID of the controller instance, e.g. `kubelet-xyzf`.
	ReportingInstance pulumi.StringPtrInput `pulumi:"reportingInstance"`
	// Data about the Event series this event represents or nil if it's a singleton Event.
	Series EventSeriesPtrInput `pulumi:"series"`
	// Type of this event (Normal, Warning), new types could be added in the future.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (EventTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventType)(nil)).Elem()
}

func (i EventTypeArgs) ToEventTypeOutput() EventTypeOutput {
	return i.ToEventTypeOutputWithContext(context.Background())
}

func (i EventTypeArgs) ToEventTypeOutputWithContext(ctx context.Context) EventTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventTypeOutput)
}

// EventTypeArrayInput is an input type that accepts EventTypeArray and EventTypeArrayOutput values.
// You can construct a concrete instance of `EventTypeArrayInput` via:
//
// 		 EventTypeArray{ EventTypeArgs{...} }
//
type EventTypeArrayInput interface {
	pulumi.Input

	ToEventTypeArrayOutput() EventTypeArrayOutput
	ToEventTypeArrayOutputWithContext(context.Context) EventTypeArrayOutput
}

type EventTypeArray []EventTypeInput

func (EventTypeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]EventType)(nil)).Elem()
}

func (i EventTypeArray) ToEventTypeArrayOutput() EventTypeArrayOutput {
	return i.ToEventTypeArrayOutputWithContext(context.Background())
}

func (i EventTypeArray) ToEventTypeArrayOutputWithContext(ctx context.Context) EventTypeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventTypeArrayOutput)
}

// Event is a report of an event somewhere in the cluster. It generally denotes some state change in the system.
type EventTypeOutput struct{ *pulumi.OutputState }

func (EventTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventType)(nil)).Elem()
}

func (o EventTypeOutput) ToEventTypeOutput() EventTypeOutput {
	return o
}

func (o EventTypeOutput) ToEventTypeOutputWithContext(ctx context.Context) EventTypeOutput {
	return o
}

// What action was taken/failed regarding to the regarding object.
func (o EventTypeOutput) Action() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.Action }).(pulumi.StringPtrOutput)
}

// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
func (o EventTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

// Deprecated field assuring backward compatibility with core.v1 Event type
func (o EventTypeOutput) DeprecatedCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v EventType) *int { return v.DeprecatedCount }).(pulumi.IntPtrOutput)
}

// Deprecated field assuring backward compatibility with core.v1 Event type
func (o EventTypeOutput) DeprecatedFirstTimestamp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.DeprecatedFirstTimestamp }).(pulumi.StringPtrOutput)
}

// Deprecated field assuring backward compatibility with core.v1 Event type
func (o EventTypeOutput) DeprecatedLastTimestamp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.DeprecatedLastTimestamp }).(pulumi.StringPtrOutput)
}

// Deprecated field assuring backward compatibility with core.v1 Event type
func (o EventTypeOutput) DeprecatedSource() corev1.EventSourcePtrOutput {
	return o.ApplyT(func(v EventType) *corev1.EventSource { return v.DeprecatedSource }).(corev1.EventSourcePtrOutput)
}

// Required. Time when this Event was first observed.
func (o EventTypeOutput) EventTime() pulumi.StringOutput {
	return o.ApplyT(func(v EventType) string { return v.EventTime }).(pulumi.StringOutput)
}

// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o EventTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

func (o EventTypeOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v EventType) *metav1.ObjectMeta { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// Optional. A human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
func (o EventTypeOutput) Note() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.Note }).(pulumi.StringPtrOutput)
}

// Why the action was taken.
func (o EventTypeOutput) Reason() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.Reason }).(pulumi.StringPtrOutput)
}

// The object this Event is about. In most cases it's an Object reporting controller implements. E.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
func (o EventTypeOutput) Regarding() corev1.ObjectReferencePtrOutput {
	return o.ApplyT(func(v EventType) *corev1.ObjectReference { return v.Regarding }).(corev1.ObjectReferencePtrOutput)
}

// Optional secondary object for more complex actions. E.g. when regarding object triggers a creation or deletion of related object.
func (o EventTypeOutput) Related() corev1.ObjectReferencePtrOutput {
	return o.ApplyT(func(v EventType) *corev1.ObjectReference { return v.Related }).(corev1.ObjectReferencePtrOutput)
}

// Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.
func (o EventTypeOutput) ReportingController() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.ReportingController }).(pulumi.StringPtrOutput)
}

// ID of the controller instance, e.g. `kubelet-xyzf`.
func (o EventTypeOutput) ReportingInstance() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.ReportingInstance }).(pulumi.StringPtrOutput)
}

// Data about the Event series this event represents or nil if it's a singleton Event.
func (o EventTypeOutput) Series() EventSeriesPtrOutput {
	return o.ApplyT(func(v EventType) *EventSeries { return v.Series }).(EventSeriesPtrOutput)
}

// Type of this event (Normal, Warning), new types could be added in the future.
func (o EventTypeOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventType) *string { return v.Type }).(pulumi.StringPtrOutput)
}

type EventTypeArrayOutput struct{ *pulumi.OutputState }

func (EventTypeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]EventType)(nil)).Elem()
}

func (o EventTypeArrayOutput) ToEventTypeArrayOutput() EventTypeArrayOutput {
	return o
}

func (o EventTypeArrayOutput) ToEventTypeArrayOutputWithContext(ctx context.Context) EventTypeArrayOutput {
	return o
}

func (o EventTypeArrayOutput) Index(i pulumi.IntInput) EventTypeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) EventType {
		return vs[0].([]EventType)[vs[1].(int)]
	}).(EventTypeOutput)
}

// EventList is a list of Event objects.
type EventListType struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Items is a list of schema objects.
	Items []EventType `pulumi:"items"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata *metav1.ListMeta `pulumi:"metadata"`
}

// EventListTypeInput is an input type that accepts EventListTypeArgs and EventListTypeOutput values.
// You can construct a concrete instance of `EventListTypeInput` via:
//
// 		 EventListTypeArgs{...}
//
type EventListTypeInput interface {
	pulumi.Input

	ToEventListTypeOutput() EventListTypeOutput
	ToEventListTypeOutputWithContext(context.Context) EventListTypeOutput
}

// EventList is a list of Event objects.
type EventListTypeArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput `pulumi:"apiVersion"`
	// Items is a list of schema objects.
	Items EventTypeArrayInput `pulumi:"items"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput `pulumi:"kind"`
	// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ListMetaPtrInput `pulumi:"metadata"`
}

func (EventListTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventListType)(nil)).Elem()
}

func (i EventListTypeArgs) ToEventListTypeOutput() EventListTypeOutput {
	return i.ToEventListTypeOutputWithContext(context.Background())
}

func (i EventListTypeArgs) ToEventListTypeOutputWithContext(ctx context.Context) EventListTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventListTypeOutput)
}

// EventList is a list of Event objects.
type EventListTypeOutput struct{ *pulumi.OutputState }

func (EventListTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventListType)(nil)).Elem()
}

func (o EventListTypeOutput) ToEventListTypeOutput() EventListTypeOutput {
	return o
}

func (o EventListTypeOutput) ToEventListTypeOutputWithContext(ctx context.Context) EventListTypeOutput {
	return o
}

// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
func (o EventListTypeOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventListType) *string { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

// Items is a list of schema objects.
func (o EventListTypeOutput) Items() EventTypeArrayOutput {
	return o.ApplyT(func(v EventListType) []EventType { return v.Items }).(EventTypeArrayOutput)
}

// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o EventListTypeOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventListType) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
func (o EventListTypeOutput) Metadata() metav1.ListMetaPtrOutput {
	return o.ApplyT(func(v EventListType) *metav1.ListMeta { return v.Metadata }).(metav1.ListMetaPtrOutput)
}

// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.
type EventSeries struct {
	// Number of occurrences in this series up to the last heartbeat time
	Count int `pulumi:"count"`
	// Time when last Event from the series was seen before last heartbeat.
	LastObservedTime string `pulumi:"lastObservedTime"`
	// Information whether this series is ongoing or finished. Deprecated. Planned removal for 1.18
	State string `pulumi:"state"`
}

// EventSeriesInput is an input type that accepts EventSeriesArgs and EventSeriesOutput values.
// You can construct a concrete instance of `EventSeriesInput` via:
//
// 		 EventSeriesArgs{...}
//
type EventSeriesInput interface {
	pulumi.Input

	ToEventSeriesOutput() EventSeriesOutput
	ToEventSeriesOutputWithContext(context.Context) EventSeriesOutput
}

// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.
type EventSeriesArgs struct {
	// Number of occurrences in this series up to the last heartbeat time
	Count pulumi.IntInput `pulumi:"count"`
	// Time when last Event from the series was seen before last heartbeat.
	LastObservedTime pulumi.StringInput `pulumi:"lastObservedTime"`
	// Information whether this series is ongoing or finished. Deprecated. Planned removal for 1.18
	State pulumi.StringInput `pulumi:"state"`
}

func (EventSeriesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventSeries)(nil)).Elem()
}

func (i EventSeriesArgs) ToEventSeriesOutput() EventSeriesOutput {
	return i.ToEventSeriesOutputWithContext(context.Background())
}

func (i EventSeriesArgs) ToEventSeriesOutputWithContext(ctx context.Context) EventSeriesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSeriesOutput)
}

func (i EventSeriesArgs) ToEventSeriesPtrOutput() EventSeriesPtrOutput {
	return i.ToEventSeriesPtrOutputWithContext(context.Background())
}

func (i EventSeriesArgs) ToEventSeriesPtrOutputWithContext(ctx context.Context) EventSeriesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSeriesOutput).ToEventSeriesPtrOutputWithContext(ctx)
}

// EventSeriesPtrInput is an input type that accepts EventSeriesArgs, EventSeriesPtr and EventSeriesPtrOutput values.
// You can construct a concrete instance of `EventSeriesPtrInput` via:
//
// 		 EventSeriesArgs{...}
//
//  or:
//
// 		 nil
//
type EventSeriesPtrInput interface {
	pulumi.Input

	ToEventSeriesPtrOutput() EventSeriesPtrOutput
	ToEventSeriesPtrOutputWithContext(context.Context) EventSeriesPtrOutput
}

type eventSeriesPtrType EventSeriesArgs

func EventSeriesPtr(v *EventSeriesArgs) EventSeriesPtrInput {
	return (*eventSeriesPtrType)(v)
}

func (*eventSeriesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**EventSeries)(nil)).Elem()
}

func (i *eventSeriesPtrType) ToEventSeriesPtrOutput() EventSeriesPtrOutput {
	return i.ToEventSeriesPtrOutputWithContext(context.Background())
}

func (i *eventSeriesPtrType) ToEventSeriesPtrOutputWithContext(ctx context.Context) EventSeriesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSeriesPtrOutput)
}

// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.
type EventSeriesOutput struct{ *pulumi.OutputState }

func (EventSeriesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventSeries)(nil)).Elem()
}

func (o EventSeriesOutput) ToEventSeriesOutput() EventSeriesOutput {
	return o
}

func (o EventSeriesOutput) ToEventSeriesOutputWithContext(ctx context.Context) EventSeriesOutput {
	return o
}

func (o EventSeriesOutput) ToEventSeriesPtrOutput() EventSeriesPtrOutput {
	return o.ToEventSeriesPtrOutputWithContext(context.Background())
}

func (o EventSeriesOutput) ToEventSeriesPtrOutputWithContext(ctx context.Context) EventSeriesPtrOutput {
	return o.ApplyT(func(v EventSeries) *EventSeries {
		return &v
	}).(EventSeriesPtrOutput)
}

// Number of occurrences in this series up to the last heartbeat time
func (o EventSeriesOutput) Count() pulumi.IntOutput {
	return o.ApplyT(func(v EventSeries) int { return v.Count }).(pulumi.IntOutput)
}

// Time when last Event from the series was seen before last heartbeat.
func (o EventSeriesOutput) LastObservedTime() pulumi.StringOutput {
	return o.ApplyT(func(v EventSeries) string { return v.LastObservedTime }).(pulumi.StringOutput)
}

// Information whether this series is ongoing or finished. Deprecated. Planned removal for 1.18
func (o EventSeriesOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v EventSeries) string { return v.State }).(pulumi.StringOutput)
}

type EventSeriesPtrOutput struct{ *pulumi.OutputState }

func (EventSeriesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EventSeries)(nil)).Elem()
}

func (o EventSeriesPtrOutput) ToEventSeriesPtrOutput() EventSeriesPtrOutput {
	return o
}

func (o EventSeriesPtrOutput) ToEventSeriesPtrOutputWithContext(ctx context.Context) EventSeriesPtrOutput {
	return o
}

func (o EventSeriesPtrOutput) Elem() EventSeriesOutput {
	return o.ApplyT(func(v *EventSeries) EventSeries { return *v }).(EventSeriesOutput)
}

// Number of occurrences in this series up to the last heartbeat time
func (o EventSeriesPtrOutput) Count() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *EventSeries) *int {
		if v == nil {
			return nil
		}
		return &v.Count
	}).(pulumi.IntPtrOutput)
}

// Time when last Event from the series was seen before last heartbeat.
func (o EventSeriesPtrOutput) LastObservedTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventSeries) *string {
		if v == nil {
			return nil
		}
		return &v.LastObservedTime
	}).(pulumi.StringPtrOutput)
}

// Information whether this series is ongoing or finished. Deprecated. Planned removal for 1.18
func (o EventSeriesPtrOutput) State() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventSeries) *string {
		if v == nil {
			return nil
		}
		return &v.State
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(EventTypeOutput{})
	pulumi.RegisterOutputType(EventTypeArrayOutput{})
	pulumi.RegisterOutputType(EventListTypeOutput{})
	pulumi.RegisterOutputType(EventSeriesOutput{})
	pulumi.RegisterOutputType(EventSeriesPtrOutput{})
}