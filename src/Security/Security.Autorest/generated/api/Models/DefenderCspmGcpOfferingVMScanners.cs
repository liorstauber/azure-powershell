// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>The Microsoft Defender for Server VM scanning configuration</summary>
    public partial class DefenderCspmGcpOfferingVMScanners :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScanners,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfiguration _configuration;

        /// <summary>configuration for Microsoft Defender for Server VM scanning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmGcpOfferingVMScannersConfiguration()); set => this._configuration = value; }

        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationInternal)Configuration).ExclusionTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationInternal)Configuration).ExclusionTag = value ?? null /* model class */; }

        /// <summary>The scanning mode for the VM scan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string ConfigurationScanningMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationInternal)Configuration).ScanningMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationInternal)Configuration).ScanningMode = value ?? null; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Internal Acessors for Configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfiguration Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersInternal.Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmGcpOfferingVMScannersConfiguration()); set { {_configuration = value;} } }

        /// <summary>Creates an new <see cref="DefenderCspmGcpOfferingVMScanners" /> instance.</summary>
        public DefenderCspmGcpOfferingVMScanners()
        {

        }
    }
    /// The Microsoft Defender for Server VM scanning configuration
    public partial interface IDefenderCspmGcpOfferingVMScanners :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable
    {
        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VM tags that indicates that VM should not be scanned",
        SerializedName = @"exclusionTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationExclusionTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get; set; }
        /// <summary>The scanning mode for the VM scan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The scanning mode for the VM scan.",
        SerializedName = @"scanningMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Default")]
        string ConfigurationScanningMode { get; set; }
        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is Microsoft Defender for Server VM scanning enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// The Microsoft Defender for Server VM scanning configuration
    internal partial interface IDefenderCspmGcpOfferingVMScannersInternal

    {
        /// <summary>configuration for Microsoft Defender for Server VM scanning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfiguration Configuration { get; set; }
        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmGcpOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get; set; }
        /// <summary>The scanning mode for the VM scan.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Default")]
        string ConfigurationScanningMode { get; set; }
        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        bool? Enabled { get; set; }

    }
}