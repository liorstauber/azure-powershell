// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>An Application Insights component feature capability</summary>
    public partial class ApplicationInsightsComponentFeatureCapability
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject into a new instance of <see cref="ApplicationInsightsComponentFeatureCapability"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApplicationInsightsComponentFeatureCapability(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("Name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("Description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_value = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("Value"), out var __jsonValue) ? (string)__jsonValue : (string)Value;}
            {_unit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("Unit"), out var __jsonUnit) ? (string)__jsonUnit : (string)Unit;}
            {_meterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("MeterId"), out var __jsonMeterId) ? (string)__jsonMeterId : (string)MeterId;}
            {_meterRateFrequency = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString>("MeterRateFrequency"), out var __jsonMeterRateFrequency) ? (string)__jsonMeterRateFrequency : (string)MeterRateFrequency;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability FromJson(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject json ? new ApplicationInsightsComponentFeatureCapability(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApplicationInsightsComponentFeatureCapability" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApplicationInsightsComponentFeatureCapability" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._name.ToString()) : null, "Name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._description.ToString()) : null, "Description" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._value)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._value.ToString()) : null, "Value" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._unit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._unit.ToString()) : null, "Unit" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._meterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._meterId.ToString()) : null, "MeterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._meterRateFrequency)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonString(this._meterRateFrequency.ToString()) : null, "MeterRateFrequency" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}