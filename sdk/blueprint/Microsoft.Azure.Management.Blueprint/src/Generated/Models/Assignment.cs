// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a blueprint assignment.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Assignment : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Assignment class.
        /// </summary>
        public Assignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Assignment class.
        /// </summary>
        /// <param name="location">The location of this blueprint
        /// assignment.</param>
        /// <param name="identity">Managed identity for this blueprint
        /// assignment.</param>
        /// <param name="parameters">Blueprint assignment parameter
        /// values.</param>
        /// <param name="resourceGroups">Names and locations of resource group
        /// placeholders.</param>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="displayName">One-liner string explain this
        /// resource.</param>
        /// <param name="description">Multi-line explain this resource.</param>
        /// <param name="blueprintId">ID of the published version of a
        /// blueprint definition.</param>
        /// <param name="scope">The target subscription scope of the blueprint
        /// assignment (format: '/subscriptions/{subscriptionId}'). For
        /// management group level assignments, the property is
        /// required.</param>
        /// <param name="status">Status of blueprint assignment. This field is
        /// readonly.</param>
        /// <param name="locks">Defines how resources deployed by a blueprint
        /// assignment are locked.</param>
        /// <param name="provisioningState">State of the blueprint assignment.
        /// Possible values include: 'creating', 'validating', 'waiting',
        /// 'deploying', 'cancelling', 'locking', 'succeeded', 'failed',
        /// 'canceled', 'deleting'</param>
        public Assignment(string location, ManagedServiceIdentity identity, IDictionary<string, ParameterValue> parameters, IDictionary<string, ResourceGroupValue> resourceGroups, string id = default(string), string type = default(string), string name = default(string), string displayName = default(string), string description = default(string), string blueprintId = default(string), string scope = default(string), AssignmentStatus status = default(AssignmentStatus), AssignmentLockSettings locks = default(AssignmentLockSettings), string provisioningState = default(string))
            : base(location, id, type, name)
        {
            Identity = identity;
            DisplayName = displayName;
            Description = description;
            BlueprintId = blueprintId;
            Scope = scope;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Status = status;
            Locks = locks;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets managed identity for this blueprint assignment.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets one-liner string explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets multi-line explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ID of the published version of a blueprint definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blueprintId")]
        public string BlueprintId { get; set; }

        /// <summary>
        /// Gets or sets the target subscription scope of the blueprint
        /// assignment (format: '/subscriptions/{subscriptionId}'). For
        /// management group level assignments, the property is required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets blueprint assignment parameter values.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, ParameterValue> Parameters { get; set; }

        /// <summary>
        /// Gets or sets names and locations of resource group placeholders.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroups")]
        public IDictionary<string, ResourceGroupValue> ResourceGroups { get; set; }

        /// <summary>
        /// Gets status of blueprint assignment. This field is readonly.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public AssignmentStatus Status { get; private set; }

        /// <summary>
        /// Gets or sets defines how resources deployed by a blueprint
        /// assignment are locked.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locks")]
        public AssignmentLockSettings Locks { get; set; }

        /// <summary>
        /// Gets state of the blueprint assignment. Possible values include:
        /// 'creating', 'validating', 'waiting', 'deploying', 'cancelling',
        /// 'locking', 'succeeded', 'failed', 'canceled', 'deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Identity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identity");
            }
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
            if (ResourceGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroups");
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
            }
            if (Parameters != null)
            {
                foreach (var valueElement in Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (ResourceGroups != null)
            {
                foreach (var valueElement1 in ResourceGroups.Values)
                {
                    if (valueElement1 != null)
                    {
                        valueElement1.Validate();
                    }
                }
            }
        }
    }
}
