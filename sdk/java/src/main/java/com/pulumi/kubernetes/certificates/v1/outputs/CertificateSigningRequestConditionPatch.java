// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.certificates.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class CertificateSigningRequestConditionPatch {
    /**
     * @return lastTransitionTime is the time the condition last transitioned from one status to another. If unset, when a new condition type is added or an existing condition&#39;s status is changed, the server defaults this to the current time.
     * 
     */
    private @Nullable String lastTransitionTime;
    /**
     * @return lastUpdateTime is the time of the last update to this condition
     * 
     */
    private @Nullable String lastUpdateTime;
    /**
     * @return message contains a human readable message with details about the request state
     * 
     */
    private @Nullable String message;
    /**
     * @return reason indicates a brief reason for the request state
     * 
     */
    private @Nullable String reason;
    /**
     * @return status of the condition, one of True, False, Unknown. Approved, Denied, and Failed conditions may not be &#34;False&#34; or &#34;Unknown&#34;.
     * 
     */
    private @Nullable String status;
    /**
     * @return type of the condition. Known conditions are &#34;Approved&#34;, &#34;Denied&#34;, and &#34;Failed&#34;.
     * 
     * An &#34;Approved&#34; condition is added via the /approval subresource, indicating the request was approved and should be issued by the signer.
     * 
     * A &#34;Denied&#34; condition is added via the /approval subresource, indicating the request was denied and should not be issued by the signer.
     * 
     * A &#34;Failed&#34; condition is added via the /status subresource, indicating the signer failed to issue the certificate.
     * 
     * Approved and Denied conditions are mutually exclusive. Approved, Denied, and Failed conditions cannot be removed once added.
     * 
     * Only one condition of a given type is allowed.
     * 
     */
    private @Nullable String type;

    private CertificateSigningRequestConditionPatch() {}
    /**
     * @return lastTransitionTime is the time the condition last transitioned from one status to another. If unset, when a new condition type is added or an existing condition&#39;s status is changed, the server defaults this to the current time.
     * 
     */
    public Optional<String> lastTransitionTime() {
        return Optional.ofNullable(this.lastTransitionTime);
    }
    /**
     * @return lastUpdateTime is the time of the last update to this condition
     * 
     */
    public Optional<String> lastUpdateTime() {
        return Optional.ofNullable(this.lastUpdateTime);
    }
    /**
     * @return message contains a human readable message with details about the request state
     * 
     */
    public Optional<String> message() {
        return Optional.ofNullable(this.message);
    }
    /**
     * @return reason indicates a brief reason for the request state
     * 
     */
    public Optional<String> reason() {
        return Optional.ofNullable(this.reason);
    }
    /**
     * @return status of the condition, one of True, False, Unknown. Approved, Denied, and Failed conditions may not be &#34;False&#34; or &#34;Unknown&#34;.
     * 
     */
    public Optional<String> status() {
        return Optional.ofNullable(this.status);
    }
    /**
     * @return type of the condition. Known conditions are &#34;Approved&#34;, &#34;Denied&#34;, and &#34;Failed&#34;.
     * 
     * An &#34;Approved&#34; condition is added via the /approval subresource, indicating the request was approved and should be issued by the signer.
     * 
     * A &#34;Denied&#34; condition is added via the /approval subresource, indicating the request was denied and should not be issued by the signer.
     * 
     * A &#34;Failed&#34; condition is added via the /status subresource, indicating the signer failed to issue the certificate.
     * 
     * Approved and Denied conditions are mutually exclusive. Approved, Denied, and Failed conditions cannot be removed once added.
     * 
     * Only one condition of a given type is allowed.
     * 
     */
    public Optional<String> type() {
        return Optional.ofNullable(this.type);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(CertificateSigningRequestConditionPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable String lastTransitionTime;
        private @Nullable String lastUpdateTime;
        private @Nullable String message;
        private @Nullable String reason;
        private @Nullable String status;
        private @Nullable String type;
        public Builder() {}
        public Builder(CertificateSigningRequestConditionPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.lastTransitionTime = defaults.lastTransitionTime;
    	      this.lastUpdateTime = defaults.lastUpdateTime;
    	      this.message = defaults.message;
    	      this.reason = defaults.reason;
    	      this.status = defaults.status;
    	      this.type = defaults.type;
        }

        @CustomType.Setter
        public Builder lastTransitionTime(@Nullable String lastTransitionTime) {
            this.lastTransitionTime = lastTransitionTime;
            return this;
        }
        @CustomType.Setter
        public Builder lastUpdateTime(@Nullable String lastUpdateTime) {
            this.lastUpdateTime = lastUpdateTime;
            return this;
        }
        @CustomType.Setter
        public Builder message(@Nullable String message) {
            this.message = message;
            return this;
        }
        @CustomType.Setter
        public Builder reason(@Nullable String reason) {
            this.reason = reason;
            return this;
        }
        @CustomType.Setter
        public Builder status(@Nullable String status) {
            this.status = status;
            return this;
        }
        @CustomType.Setter
        public Builder type(@Nullable String type) {
            this.type = type;
            return this;
        }
        public CertificateSigningRequestConditionPatch build() {
            final var o = new CertificateSigningRequestConditionPatch();
            o.lastTransitionTime = lastTransitionTime;
            o.lastUpdateTime = lastUpdateTime;
            o.message = message;
            o.reason = reason;
            o.status = status;
            o.type = type;
            return o;
        }
    }
}