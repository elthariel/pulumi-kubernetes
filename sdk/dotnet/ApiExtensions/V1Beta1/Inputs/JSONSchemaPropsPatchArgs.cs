// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1
{

    /// <summary>
    /// JSONSchemaProps is a JSON-Schema following Specification Draft 4 (http://json-schema.org/).
    /// </summary>
    public class JSONSchemaPropsPatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("$ref")]
        public Input<string>? Ref { get; set; }

        [Input("$schema")]
        public Input<string>? Schema { get; set; }

        [Input("additionalItems")]
        public InputUnion<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, bool>? AdditionalItems { get; set; }

        [Input("additionalProperties")]
        public InputUnion<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, bool>? AdditionalProperties { get; set; }

        [Input("allOf")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>? _allOf;
        public InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs> AllOf
        {
            get => _allOf ?? (_allOf = new InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>());
            set => _allOf = value;
        }

        [Input("anyOf")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>? _anyOf;
        public InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs> AnyOf
        {
            get => _anyOf ?? (_anyOf = new InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>());
            set => _anyOf = value;
        }

        /// <summary>
        /// default is a default value for undefined object fields. Defaulting is a beta feature under the CustomResourceDefaulting feature gate. CustomResourceDefinitions with defaults must be created using the v1 (or newer) CustomResourceDefinition API.
        /// </summary>
        [Input("default")]
        public InputJson? Default { get; set; }

        [Input("definitions")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>? _definitions;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs> Definitions
        {
            get => _definitions ?? (_definitions = new InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>());
            set => _definitions = value;
        }

        [Input("dependencies")]
        private InputMap<Union<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, ImmutableArray<string>>>? _dependencies;
        public InputMap<Union<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, ImmutableArray<string>>> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputMap<Union<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, ImmutableArray<string>>>());
            set => _dependencies = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("enum")]
        private InputList<System.Text.Json.JsonElement>? _enum;
        public InputList<System.Text.Json.JsonElement> Enum
        {
            get => _enum ?? (_enum = new InputList<System.Text.Json.JsonElement>());
            set => _enum = value;
        }

        [Input("example")]
        public InputJson? Example { get; set; }

        [Input("exclusiveMaximum")]
        public Input<bool>? ExclusiveMaximum { get; set; }

        [Input("exclusiveMinimum")]
        public Input<bool>? ExclusiveMinimum { get; set; }

        [Input("externalDocs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.ExternalDocumentationPatchArgs>? ExternalDocs { get; set; }

        /// <summary>
        /// format is an OpenAPI v3 format string. Unknown formats are ignored. The following formats are validated:
        /// 
        /// - bsonobjectid: a bson object ID, i.e. a 24 characters hex string - uri: an URI as parsed by Golang net/url.ParseRequestURI - email: an email address as parsed by Golang net/mail.ParseAddress - hostname: a valid representation for an Internet host name, as defined by RFC 1034, section 3.1 [RFC1034]. - ipv4: an IPv4 IP as parsed by Golang net.ParseIP - ipv6: an IPv6 IP as parsed by Golang net.ParseIP - cidr: a CIDR as parsed by Golang net.ParseCIDR - mac: a MAC address as parsed by Golang net.ParseMAC - uuid: an UUID that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid3: an UUID3 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?3[0-9a-f]{3}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid4: an UUID4 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?4[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - uuid5: an UUID5 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?5[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - isbn: an ISBN10 or ISBN13 number string like "0321751043" or "978-0321751041" - isbn10: an ISBN10 number string like "0321751043" - isbn13: an ISBN13 number string like "978-0321751041" - creditcard: a credit card number defined by the regex ^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$ with any non digit characters mixed in - ssn: a U.S. social security number following the regex ^\d{3}[- ]?\d{2}[- ]?\d{4}$ - hexcolor: an hexadecimal color code like "#FFFFFF: following the regex ^#?([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$ - rgbcolor: an RGB color code like rgb like "rgb(255,255,2559" - byte: base64 encoded binary data - password: any kind of string - date: a date string like "2006-01-02" as defined by full-date in RFC3339 - duration: a duration string like "22 ns" as parsed by Golang time.ParseDuration or compatible with Scala duration format - datetime: a date time string like "2014-12-15T19:30:20.000Z" as defined by date-time in RFC3339.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("items")]
        public InputUnion<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs, ImmutableArray<System.Text.Json.JsonElement>>? Items { get; set; }

        [Input("maxItems")]
        public Input<int>? MaxItems { get; set; }

        [Input("maxLength")]
        public Input<int>? MaxLength { get; set; }

        [Input("maxProperties")]
        public Input<int>? MaxProperties { get; set; }

        [Input("maximum")]
        public Input<double>? Maximum { get; set; }

        [Input("minItems")]
        public Input<int>? MinItems { get; set; }

        [Input("minLength")]
        public Input<int>? MinLength { get; set; }

        [Input("minProperties")]
        public Input<int>? MinProperties { get; set; }

        [Input("minimum")]
        public Input<double>? Minimum { get; set; }

        [Input("multipleOf")]
        public Input<double>? MultipleOf { get; set; }

        [Input("not")]
        public Input<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>? Not { get; set; }

        [Input("nullable")]
        public Input<bool>? Nullable { get; set; }

        [Input("oneOf")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>? _oneOf;
        public InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs> OneOf
        {
            get => _oneOf ?? (_oneOf = new InputList<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsPatchArgs>());
            set => _oneOf = value;
        }

        [Input("pattern")]
        public Input<string>? Pattern { get; set; }

        [Input("patternProperties")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>? _patternProperties;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs> PatternProperties
        {
            get => _patternProperties ?? (_patternProperties = new InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>());
            set => _patternProperties = value;
        }

        [Input("properties")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>? _properties;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs> Properties
        {
            get => _properties ?? (_properties = new InputMap<Pulumi.Kubernetes.Types.Inputs.ApiExtensions.V1Beta1.JSONSchemaPropsArgs>());
            set => _properties = value;
        }

        [Input("required")]
        private InputList<string>? _required;
        public InputList<string> Required
        {
            get => _required ?? (_required = new InputList<string>());
            set => _required = value;
        }

        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("uniqueItems")]
        public Input<bool>? UniqueItems { get; set; }

        /// <summary>
        /// x-kubernetes-embedded-resource defines that the value is an embedded Kubernetes runtime.Object, with TypeMeta and ObjectMeta. The type must be object. It is allowed to further restrict the embedded object. kind, apiVersion and metadata are validated automatically. x-kubernetes-preserve-unknown-fields is allowed to be true, but does not have to be if the object is fully specified (up to kind, apiVersion, metadata).
        /// </summary>
        [Input("x_kubernetes_embedded_resource")]
        public Input<bool>? X_kubernetes_embedded_resource { get; set; }

        /// <summary>
        /// x-kubernetes-int-or-string specifies that this value is either an integer or a string. If this is true, an empty type is allowed and type as child of anyOf is permitted if following one of the following patterns:
        /// 
        /// 1) anyOf:
        ///    - type: integer
        ///    - type: string
        /// 2) allOf:
        ///    - anyOf:
        ///      - type: integer
        ///      - type: string
        ///    - ... zero or more
        /// </summary>
        [Input("x_kubernetes_int_or_string")]
        public Input<bool>? X_kubernetes_int_or_string { get; set; }

        [Input("x_kubernetes_list_map_keys")]
        private InputList<string>? _x_kubernetes_list_map_keys;

        /// <summary>
        /// x-kubernetes-list-map-keys annotates an array with the x-kubernetes-list-type `map` by specifying the keys used as the index of the map.
        /// 
        /// This tag MUST only be used on lists that have the "x-kubernetes-list-type" extension set to "map". Also, the values specified for this attribute must be a scalar typed field of the child structure (no nesting is supported).
        /// </summary>
        public InputList<string> X_kubernetes_list_map_keys
        {
            get => _x_kubernetes_list_map_keys ?? (_x_kubernetes_list_map_keys = new InputList<string>());
            set => _x_kubernetes_list_map_keys = value;
        }

        /// <summary>
        /// x-kubernetes-list-type annotates an array to further describe its topology. This extension must only be used on lists and may have 3 possible values:
        /// 
        /// 1) `atomic`: the list is treated as a single entity, like a scalar.
        ///      Atomic lists will be entirely replaced when updated. This extension
        ///      may be used on any type of list (struct, scalar, ...).
        /// 2) `set`:
        ///      Sets are lists that must not have multiple items with the same value. Each
        ///      value must be a scalar, an object with x-kubernetes-map-type `atomic` or an
        ///      array with x-kubernetes-list-type `atomic`.
        /// 3) `map`:
        ///      These lists are like maps in that their elements have a non-index key
        ///      used to identify them. Order is preserved upon merge. The map tag
        ///      must only be used on a list with elements of type object.
        /// Defaults to atomic for arrays.
        /// </summary>
        [Input("x_kubernetes_list_type")]
        public Input<string>? X_kubernetes_list_type { get; set; }

        /// <summary>
        /// x-kubernetes-map-type annotates an object to further describe its topology. This extension must only be used when type is object and may have 2 possible values:
        /// 
        /// 1) `granular`:
        ///      These maps are actual maps (key-value pairs) and each fields are independent
        ///      from each other (they can each be manipulated by separate actors). This is
        ///      the default behaviour for all maps.
        /// 2) `atomic`: the list is treated as a single entity, like a scalar.
        ///      Atomic maps will be entirely replaced when updated.
        /// </summary>
        [Input("x_kubernetes_map_type")]
        public Input<string>? X_kubernetes_map_type { get; set; }

        /// <summary>
        /// x-kubernetes-preserve-unknown-fields stops the API server decoding step from pruning fields which are not specified in the validation schema. This affects fields recursively, but switches back to normal pruning behaviour if nested properties or additionalProperties are specified in the schema. This can either be true or undefined. False is forbidden.
        /// </summary>
        [Input("x_kubernetes_preserve_unknown_fields")]
        public Input<bool>? X_kubernetes_preserve_unknown_fields { get; set; }

        public JSONSchemaPropsPatchArgs()
        {
        }
        public static new JSONSchemaPropsPatchArgs Empty => new JSONSchemaPropsPatchArgs();
    }
}
