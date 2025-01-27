// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusNetworkRuleSet data model.
    /// Description of NetworkRuleSet resource.
    /// </summary>
    public partial class ServiceBusNetworkRuleSetData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceBusNetworkRuleSetData"/>. </summary>
        public ServiceBusNetworkRuleSetData()
        {
            VirtualNetworkRules = new ChangeTrackingList<ServiceBusNetworkRuleSetVirtualNetworkRules>();
            IPRules = new ChangeTrackingList<ServiceBusNetworkRuleSetIPRules>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusNetworkRuleSetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isTrustedServiceAccessEnabled"> Value that indicates whether Trusted Service Access is Enabled or not. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusNetworkRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isTrustedServiceAccessEnabled, ServiceBusNetworkRuleSetDefaultAction? defaultAction, IList<ServiceBusNetworkRuleSetVirtualNetworkRules> virtualNetworkRules, IList<ServiceBusNetworkRuleSetIPRules> ipRules, ServiceBusPublicNetworkAccessFlag? publicNetworkAccess, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            IsTrustedServiceAccessEnabled = isTrustedServiceAccessEnabled;
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IPRules = ipRules;
            PublicNetworkAccess = publicNetworkAccess;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Value that indicates whether Trusted Service Access is Enabled or not. </summary>
        public bool? IsTrustedServiceAccessEnabled { get; set; }
        /// <summary> Default Action for Network Rule Set. </summary>
        public ServiceBusNetworkRuleSetDefaultAction? DefaultAction { get; set; }
        /// <summary> List VirtualNetwork Rules. </summary>
        public IList<ServiceBusNetworkRuleSetVirtualNetworkRules> VirtualNetworkRules { get; }
        /// <summary> List of IpRules. </summary>
        public IList<ServiceBusNetworkRuleSetIPRules> IPRules { get; }
        /// <summary> This determines if traffic is allowed over public network. By default it is enabled. </summary>
        public ServiceBusPublicNetworkAccessFlag? PublicNetworkAccess { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
