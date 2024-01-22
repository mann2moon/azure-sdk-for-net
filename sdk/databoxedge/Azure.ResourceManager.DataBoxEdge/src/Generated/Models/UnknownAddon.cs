// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The UnknownAddon. </summary>
    internal partial class UnknownAddon : DataBoxEdgeRoleAddonData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAddon"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAddon(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }
    }
}
