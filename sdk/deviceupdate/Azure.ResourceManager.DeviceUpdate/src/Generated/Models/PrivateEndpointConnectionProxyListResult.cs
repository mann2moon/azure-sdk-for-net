// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DeviceUpdate;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The available private endpoint connection proxies for an Account (not to be used by anyone, here because of ARM requirements). </summary>
    internal partial class PrivateEndpointConnectionProxyListResult
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

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionProxyListResult"/>. </summary>
        internal PrivateEndpointConnectionProxyListResult()
        {
            Value = new ChangeTrackingList<DeviceUpdatePrivateEndpointConnectionProxyData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionProxyListResult"/>. </summary>
        /// <param name="value"> The list of available private endpoint connection proxies for an Account. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of private endpoint connection proxies. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointConnectionProxyListResult(IReadOnlyList<DeviceUpdatePrivateEndpointConnectionProxyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of available private endpoint connection proxies for an Account. </summary>
        public IReadOnlyList<DeviceUpdatePrivateEndpointConnectionProxyData> Value { get; }
        /// <summary> The URI that can be used to request the next list of private endpoint connection proxies. </summary>
        public string NextLink { get; }
    }
}
