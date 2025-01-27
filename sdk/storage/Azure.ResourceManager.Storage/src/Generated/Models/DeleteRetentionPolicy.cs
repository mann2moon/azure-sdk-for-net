// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The service properties for soft delete. </summary>
    public partial class DeleteRetentionPolicy
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

        /// <summary> Initializes a new instance of <see cref="DeleteRetentionPolicy"/>. </summary>
        public DeleteRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeleteRetentionPolicy"/>. </summary>
        /// <param name="isEnabled"> Indicates whether DeleteRetentionPolicy is enabled. </param>
        /// <param name="days"> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </param>
        /// <param name="allowPermanentDelete"> This property when set to true allows deletion of the soft deleted blob versions and snapshots. This property cannot be used blob restore policy. This property only applies to blob service and does not apply to containers or file share. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteRetentionPolicy(bool? isEnabled, int? days, bool? allowPermanentDelete, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Days = days;
            AllowPermanentDelete = allowPermanentDelete;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether DeleteRetentionPolicy is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365. </summary>
        public int? Days { get; set; }
        /// <summary> This property when set to true allows deletion of the soft deleted blob versions and snapshots. This property cannot be used blob restore policy. This property only applies to blob service and does not apply to containers or file share. </summary>
        public bool? AllowPermanentDelete { get; set; }
    }
}
