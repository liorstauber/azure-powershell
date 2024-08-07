// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>The Client resource.</summary>
    public partial class Client :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClient,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.Resource();

        /// <summary>
        /// Attributes for the client. Supported values are int, bool, string, string[].
        /// Example:
        /// "attributes": { "room": "345", "floor": 12, "deviceTypes": ["Fan", "Light"] }
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesAttributes Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>
        /// The name presented by the client for authentication. The default value is the name of the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string AuthenticationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationName = value ?? null; }

        /// <summary>
        /// The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme
        /// is 'ThumbprintMatch'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> CertificateAuthenticationAllowedThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthenticationAllowedThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthenticationAllowedThumbprint = value ?? null /* arrayOf */; }

        /// <summary>
        /// The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateAuthenticationValidationScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthenticationValidationScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthenticationValidationScheme = value ?? null; }

        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateSubjectCommonName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectCommonName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectCommonName = value ?? null; }

        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateSubjectCountryCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectCountryCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectCountryCode = value ?? null; }

        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateSubjectOrganization { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectOrganization; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectOrganization = value ?? null; }

        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateSubjectOrganizationUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectOrganizationUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateSubjectOrganizationUnit = value ?? null; }

        /// <summary>The primary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateThumbprintPrimary { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateThumbprintPrimary; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateThumbprintPrimary = value ?? null; }

        /// <summary>The secondary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string CertificateThumbprintSecondary { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateThumbprintSecondary; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).CertificateThumbprintSecondary = value ?? null; }

        /// <summary>Description for the Client resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Fully qualified identifier of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientAuthentication Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.Authentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Authentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).Authentication = value; }

        /// <summary>Internal Acessors for AuthenticationCertificateSubject</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateSubjectDistinguishedName Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.AuthenticationCertificateSubject { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationCertificateSubject; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationCertificateSubject = value; }

        /// <summary>Internal Acessors for AuthenticationCertificateThumbprint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateThumbprint Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.AuthenticationCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationCertificateThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).AuthenticationCertificateThumbprint = value; }

        /// <summary>Internal Acessors for CertificateAuthentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateAuthentication Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.CertificateAuthentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ClientCertificateAuthentication = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientProperties Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ClientProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientProperties _property;

        /// <summary>The properties of client.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ClientProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the Client resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Indicates if the client is enabled or not. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesInternal)Property).State = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemData _systemData;

        /// <summary>The system metadata relating to the Client resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).CreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemDataInternal)SystemData).LastModifiedByType = value ?? null; }

        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Client" /> instance.</summary>
        public Client()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The Client resource.
    public partial interface IClient :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResource
    {
        /// <summary>
        /// Attributes for the client. Supported values are int, bool, string, string[].
        /// Example:
        /// "attributes": { "room": "345", "floor": 12, "deviceTypes": ["Fan", "Light"] }
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Attributes for the client. Supported values are int, bool, string, string[].
        Example:
        ""attributes"": { ""room"": ""345"", ""floor"": 12, ""deviceTypes"": [""Fan"", ""Light""] }",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesAttributes) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesAttributes Attribute { get; set; }
        /// <summary>
        /// The name presented by the client for authentication. The default value is the name of the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name presented by the client for authentication. The default value is the name of the resource.",
        SerializedName = @"authenticationName",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationName { get; set; }
        /// <summary>
        /// The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme
        /// is 'ThumbprintMatch'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme is 'ThumbprintMatch'.",
        SerializedName = @"allowedThumbprints",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> CertificateAuthenticationAllowedThumbprint { get; set; }
        /// <summary>
        /// The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName.",
        SerializedName = @"validationScheme",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("SubjectMatchesAuthenticationName", "DnsMatchesAuthenticationName", "UriMatchesAuthenticationName", "IpMatchesAuthenticationName", "EmailMatchesAuthenticationName", "ThumbprintMatch")]
        string CertificateAuthenticationValidationScheme { get; set; }
        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The common name field in the subject name. The allowed limit is 64 characters and it should be specified.",
        SerializedName = @"commonName",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSubjectCommonName { get; set; }
        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The country code field in the subject name. If present, the country code should be represented by two-letter code defined in ISO 2166-1 (alpha-2). For example: 'US'.",
        SerializedName = @"countryCode",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSubjectCountryCode { get; set; }
        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The organization field in the subject name. If present, the allowed limit is 64 characters.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSubjectOrganization { get; set; }
        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The organization unit field in the subject name. If present, the allowed limit is 32 characters.",
        SerializedName = @"organizationUnit",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSubjectOrganizationUnit { get; set; }
        /// <summary>The primary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The primary thumbprint used for validation.",
        SerializedName = @"primary",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateThumbprintPrimary { get; set; }
        /// <summary>The secondary thumbprint used for validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The secondary thumbprint used for validation.",
        SerializedName = @"secondary",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateThumbprintSecondary { get; set; }
        /// <summary>Description for the Client resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description for the Client resource.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Provisioning state of the Client resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the Client resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>Indicates if the client is enabled or not. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the client is enabled or not. Default value is Enabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string State { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get;  }

    }
    /// The Client resource.
    internal partial interface IClientInternal :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IResourceInternal
    {
        /// <summary>
        /// Attributes for the client. Supported values are int, bool, string, string[].
        /// Example:
        /// "attributes": { "room": "345", "floor": 12, "deviceTypes": ["Fan", "Light"] }
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientPropertiesAttributes Attribute { get; set; }
        /// <summary>Authentication information for the client.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientAuthentication Authentication { get; set; }
        /// <summary>The CA certificate subject name used for authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateSubjectDistinguishedName AuthenticationCertificateSubject { get; set; }
        /// <summary>The self signed certificate's thumbprints data used for authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateThumbprint AuthenticationCertificateThumbprint { get; set; }
        /// <summary>
        /// The name presented by the client for authentication. The default value is the name of the resource.
        /// </summary>
        string AuthenticationName { get; set; }
        /// <summary>The client certificate authentication information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateAuthentication CertificateAuthentication { get; set; }
        /// <summary>
        /// The list of thumbprints that are allowed during client authentication. This property is required only if the validationScheme
        /// is 'ThumbprintMatch'.
        /// </summary>
        System.Collections.Generic.List<string> CertificateAuthenticationAllowedThumbprint { get; set; }
        /// <summary>
        /// The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("SubjectMatchesAuthenticationName", "DnsMatchesAuthenticationName", "UriMatchesAuthenticationName", "IpMatchesAuthenticationName", "EmailMatchesAuthenticationName", "ThumbprintMatch")]
        string CertificateAuthenticationValidationScheme { get; set; }
        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        string CertificateSubjectCommonName { get; set; }
        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        string CertificateSubjectCountryCode { get; set; }
        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        string CertificateSubjectOrganization { get; set; }
        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        string CertificateSubjectOrganizationUnit { get; set; }
        /// <summary>The primary thumbprint used for validation.</summary>
        string CertificateThumbprintPrimary { get; set; }
        /// <summary>The secondary thumbprint used for validation.</summary>
        string CertificateThumbprintSecondary { get; set; }
        /// <summary>Description for the Client resource.</summary>
        string Description { get; set; }
        /// <summary>The properties of client.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientProperties Property { get; set; }
        /// <summary>Provisioning state of the Client resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>Indicates if the client is enabled or not. Default value is Enabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string State { get; set; }
        /// <summary>The system metadata relating to the Client resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get; set; }

    }
}