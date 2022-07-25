// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.autoscaling.v2.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.autoscaling.v2.outputs.ContainerResourceMetricStatusPatch;
import com.pulumi.kubernetes.autoscaling.v2.outputs.ExternalMetricStatusPatch;
import com.pulumi.kubernetes.autoscaling.v2.outputs.ObjectMetricStatusPatch;
import com.pulumi.kubernetes.autoscaling.v2.outputs.PodsMetricStatusPatch;
import com.pulumi.kubernetes.autoscaling.v2.outputs.ResourceMetricStatusPatch;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class MetricStatusPatch {
    /**
     * @return container resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the &#34;pods&#34; source.
     * 
     */
    private @Nullable ContainerResourceMetricStatusPatch containerResource;
    /**
     * @return external refers to a global metric that is not associated with any Kubernetes object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
     * 
     */
    private @Nullable ExternalMetricStatusPatch external;
    /**
     * @return object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).
     * 
     */
    private @Nullable ObjectMetricStatusPatch object;
    /**
     * @return pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.
     * 
     */
    private @Nullable PodsMetricStatusPatch pods;
    /**
     * @return resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the &#34;pods&#34; source.
     * 
     */
    private @Nullable ResourceMetricStatusPatch resource;
    /**
     * @return type is the type of metric source.  It will be one of &#34;ContainerResource&#34;, &#34;External&#34;, &#34;Object&#34;, &#34;Pods&#34; or &#34;Resource&#34;, each corresponds to a matching field in the object. Note: &#34;ContainerResource&#34; type is available on when the feature-gate HPAContainerMetrics is enabled
     * 
     */
    private @Nullable String type;

    private MetricStatusPatch() {}
    /**
     * @return container resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the &#34;pods&#34; source.
     * 
     */
    public Optional<ContainerResourceMetricStatusPatch> containerResource() {
        return Optional.ofNullable(this.containerResource);
    }
    /**
     * @return external refers to a global metric that is not associated with any Kubernetes object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
     * 
     */
    public Optional<ExternalMetricStatusPatch> external() {
        return Optional.ofNullable(this.external);
    }
    /**
     * @return object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).
     * 
     */
    public Optional<ObjectMetricStatusPatch> object() {
        return Optional.ofNullable(this.object);
    }
    /**
     * @return pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.
     * 
     */
    public Optional<PodsMetricStatusPatch> pods() {
        return Optional.ofNullable(this.pods);
    }
    /**
     * @return resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the &#34;pods&#34; source.
     * 
     */
    public Optional<ResourceMetricStatusPatch> resource() {
        return Optional.ofNullable(this.resource);
    }
    /**
     * @return type is the type of metric source.  It will be one of &#34;ContainerResource&#34;, &#34;External&#34;, &#34;Object&#34;, &#34;Pods&#34; or &#34;Resource&#34;, each corresponds to a matching field in the object. Note: &#34;ContainerResource&#34; type is available on when the feature-gate HPAContainerMetrics is enabled
     * 
     */
    public Optional<String> type() {
        return Optional.ofNullable(this.type);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(MetricStatusPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable ContainerResourceMetricStatusPatch containerResource;
        private @Nullable ExternalMetricStatusPatch external;
        private @Nullable ObjectMetricStatusPatch object;
        private @Nullable PodsMetricStatusPatch pods;
        private @Nullable ResourceMetricStatusPatch resource;
        private @Nullable String type;
        public Builder() {}
        public Builder(MetricStatusPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.containerResource = defaults.containerResource;
    	      this.external = defaults.external;
    	      this.object = defaults.object;
    	      this.pods = defaults.pods;
    	      this.resource = defaults.resource;
    	      this.type = defaults.type;
        }

        @CustomType.Setter
        public Builder containerResource(@Nullable ContainerResourceMetricStatusPatch containerResource) {
            this.containerResource = containerResource;
            return this;
        }
        @CustomType.Setter
        public Builder external(@Nullable ExternalMetricStatusPatch external) {
            this.external = external;
            return this;
        }
        @CustomType.Setter
        public Builder object(@Nullable ObjectMetricStatusPatch object) {
            this.object = object;
            return this;
        }
        @CustomType.Setter
        public Builder pods(@Nullable PodsMetricStatusPatch pods) {
            this.pods = pods;
            return this;
        }
        @CustomType.Setter
        public Builder resource(@Nullable ResourceMetricStatusPatch resource) {
            this.resource = resource;
            return this;
        }
        @CustomType.Setter
        public Builder type(@Nullable String type) {
            this.type = type;
            return this;
        }
        public MetricStatusPatch build() {
            final var o = new MetricStatusPatch();
            o.containerResource = containerResource;
            o.external = external;
            o.object = object;
            o.pods = pods;
            o.resource = resource;
            o.type = type;
            return o;
        }
    }
}