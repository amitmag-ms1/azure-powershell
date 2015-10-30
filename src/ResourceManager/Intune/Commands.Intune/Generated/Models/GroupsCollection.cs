// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Commands.Intune.RestClient.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class GroupsCollection
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Group> Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextlink")]
        public string Nextlink { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (this.Value != null)
            {
                foreach (var element in this.Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
