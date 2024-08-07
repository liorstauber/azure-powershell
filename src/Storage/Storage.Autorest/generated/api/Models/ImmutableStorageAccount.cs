// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    /// <summary>
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    public partial class ImmutableStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IImmutableStorageAccount,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IImmutableStorageAccountInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability
        /// enabled by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="ImmutabilityPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyProperties _immutabilityPolicy;

        /// <summary>
        /// Specifies the default account-level immutability policy which is inherited and applied to objects that do not possess
        /// an explicit immutability policy at the object level. The object-level immutability policy has higher precedence than the
        /// container-level immutability policy, which has a higher precedence than the account-level immutability policy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyProperties ImmutabilityPolicy { get => (this._immutabilityPolicy = this._immutabilityPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.AccountImmutabilityPolicyProperties()); set => this._immutabilityPolicy = value; }

        /// <summary>
        /// This property can only be changed for disabled and unlocked time-based retention policies. When enabled, new blocks can
        /// be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and
        /// any existing blocks cannot be modified or deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public bool? ImmutabilityPolicyAllowProtectedAppendWrite { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).AllowProtectedAppendWrite; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).AllowProtectedAppendWrite = value ?? default(bool); }

        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public int? ImmutabilityPolicyImmutabilityPeriodSinceCreationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).ImmutabilityPeriodSinceCreationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).ImmutabilityPeriodSinceCreationInDay = value ?? default(int); }

        /// <summary>
        /// The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state allows
        /// increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked
        /// state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked
        /// state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which
        /// cannot be reverted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public string ImmutabilityPolicyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyPropertiesInternal)ImmutabilityPolicy).State = value ?? null; }

        /// <summary>Internal Acessors for ImmutabilityPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyProperties Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IImmutableStorageAccountInternal.ImmutabilityPolicy { get => (this._immutabilityPolicy = this._immutabilityPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.AccountImmutabilityPolicyProperties()); set { {_immutabilityPolicy = value;} } }

        /// <summary>Creates an new <see cref="ImmutableStorageAccount" /> instance.</summary>
        public ImmutableStorageAccount()
        {

        }
    }
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    public partial interface IImmutableStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability
        /// enabled by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability enabled by default.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// This property can only be changed for disabled and unlocked time-based retention policies. When enabled, new blocks can
        /// be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and
        /// any existing blocks cannot be modified or deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property can only be changed for disabled and unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted.",
        SerializedName = @"allowProtectedAppendWrites",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ImmutabilityPolicyAllowProtectedAppendWrite { get; set; }
        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The immutability period for the blobs in the container since the policy creation, in days.",
        SerializedName = @"immutabilityPeriodSinceCreationInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? ImmutabilityPolicyImmutabilityPeriodSinceCreationInDay { get; set; }
        /// <summary>
        /// The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state allows
        /// increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked
        /// state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked
        /// state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which
        /// cannot be reverted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which cannot be reverted.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Unlocked", "Locked", "Disabled")]
        string ImmutabilityPolicyState { get; set; }

    }
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    internal partial interface IImmutableStorageAccountInternal

    {
        /// <summary>
        /// A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability
        /// enabled by default.
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Specifies the default account-level immutability policy which is inherited and applied to objects that do not possess
        /// an explicit immutability policy at the object level. The object-level immutability policy has higher precedence than the
        /// container-level immutability policy, which has a higher precedence than the account-level immutability policy.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IAccountImmutabilityPolicyProperties ImmutabilityPolicy { get; set; }
        /// <summary>
        /// This property can only be changed for disabled and unlocked time-based retention policies. When enabled, new blocks can
        /// be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and
        /// any existing blocks cannot be modified or deleted.
        /// </summary>
        bool? ImmutabilityPolicyAllowProtectedAppendWrite { get; set; }
        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        int? ImmutabilityPolicyImmutabilityPeriodSinceCreationInDay { get; set; }
        /// <summary>
        /// The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state allows
        /// increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites property, Locked
        /// state only allows the increase of the immutability retention time. A policy can only be created in a Disabled or Unlocked
        /// state and can be toggled between the two states. Only a policy in an Unlocked state can transition to a Locked state which
        /// cannot be reverted.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Unlocked", "Locked", "Disabled")]
        string ImmutabilityPolicyState { get; set; }

    }
}