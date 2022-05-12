// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    public partial class ErrorResponseComponents :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponents,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsError _error;

        /// <summary>
        /// Error response indicates Insights service is not able to process the incoming request. The reason is provided in the error
        /// message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.ErrorResponseComponentsError()); set => this._error = value; }

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsError Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.ErrorResponseComponentsError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsErrorInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ErrorResponseComponents" /> instance.</summary>
        public ErrorResponseComponents()
        {

        }
    }
    public partial interface IErrorResponseComponents :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    internal partial interface IErrorResponseComponentsInternal

    {
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>
        /// Error response indicates Insights service is not able to process the incoming request. The reason is provided in the error
        /// message.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IErrorResponseComponentsError Error { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}