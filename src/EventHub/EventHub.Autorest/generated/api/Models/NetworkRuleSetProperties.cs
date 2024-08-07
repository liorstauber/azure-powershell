// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>NetworkRuleSet properties</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class NetworkRuleSetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkRuleSetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkRuleSetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DefaultAction" /> property.</summary>
        private string _defaultAction;

        /// <summary>Default Action for Network Rule Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string DefaultAction { get => this._defaultAction; set => this._defaultAction = value; }

        /// <summary>Backing field for <see cref="IPRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetIPRules> _iPRule;

        /// <summary>List of IpRules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetIPRules> IPRule { get => this._iPRule; set => this._iPRule = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then
        /// Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="TrustedServiceAccessEnabled" /> property.</summary>
        private bool? _trustedServiceAccessEnabled;

        /// <summary>Value that indicates whether Trusted Service Access is Enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public bool? TrustedServiceAccessEnabled { get => this._trustedServiceAccessEnabled; set => this._trustedServiceAccessEnabled = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetVirtualNetworkRules> _virtualNetworkRule;

        /// <summary>List VirtualNetwork Rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetVirtualNetworkRules> VirtualNetworkRule { get => this._virtualNetworkRule; set => this._virtualNetworkRule = value; }

        /// <summary>Creates an new <see cref="NetworkRuleSetProperties" /> instance.</summary>
        public NetworkRuleSetProperties()
        {

        }
    }
    /// NetworkRuleSet properties
    public partial interface INetworkRuleSetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>Default Action for Network Rule Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Default Action for Network Rule Set",
        SerializedName = @"defaultAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Allow", "Deny")]
        string DefaultAction { get; set; }
        /// <summary>List of IpRules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of IpRules",
        SerializedName = @"ipRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetIPRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetIPRules> IPRule { get; set; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then
        /// Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules. ",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Enabled", "Disabled", "SecuredByPerimeter")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Value that indicates whether Trusted Service Access is Enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value that indicates whether Trusted Service Access is Enabled or not.",
        SerializedName = @"trustedServiceAccessEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TrustedServiceAccessEnabled { get; set; }
        /// <summary>List VirtualNetwork Rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List VirtualNetwork Rules",
        SerializedName = @"virtualNetworkRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetVirtualNetworkRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetVirtualNetworkRules> VirtualNetworkRule { get; set; }

    }
    /// NetworkRuleSet properties
    internal partial interface INetworkRuleSetPropertiesInternal

    {
        /// <summary>Default Action for Network Rule Set</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Allow", "Deny")]
        string DefaultAction { get; set; }
        /// <summary>List of IpRules</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetIPRules> IPRule { get; set; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled. If value is SecuredByPerimeter then
        /// Inbound and Outbound communication is controlled by the network security perimeter and profile's access rules.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Enabled", "Disabled", "SecuredByPerimeter")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Value that indicates whether Trusted Service Access is Enabled or not.</summary>
        bool? TrustedServiceAccessEnabled { get; set; }
        /// <summary>List VirtualNetwork Rules</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INwRuleSetVirtualNetworkRules> VirtualNetworkRule { get; set; }

    }
}