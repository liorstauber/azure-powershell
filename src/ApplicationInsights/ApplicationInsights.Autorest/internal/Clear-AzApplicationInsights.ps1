
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Purges data in an Application Insights component by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.
.Description
Purges data in an Application Insights component by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBody
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.IApplicationInsightsIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IComponentPurgeBody>: Describes the body of a purge request for an App Insights component
  Filter <IComponentPurgeBodyFilters[]>: The set of columns and filters (queries) to run over them to purge the resulting data.
    [Column <String>]: The column of the table over which the given query should run
    [Key <String>]: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
    [Operator <String>]: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
    [Value <IAny>]: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.
  Table <String>: Table from which to purge data.

FILTER <IComponentPurgeBodyFilters[]>: The set of columns and filters (queries) to run over them to purge the resulting data.
  [Column <String>]: The column of the table over which the given query should run
  [Key <String>]: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
  [Operator <String>]: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
  [Value <IAny>]: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.

INPUTOBJECT <IApplicationInsightsIdentity>: Identity Parameter
  [AnnotationId <String>]: The unique annotation ID. This is unique within a Application Insights component.
  [ComponentName <String>]: The name of the Application Insights component resource.
  [ExportId <String>]: The Continuous Export configuration ID. This is unique within a Application Insights component.
  [Id <String>]: Resource identity path
  [KeyId <String>]: The API Key ID. This is unique within a Application Insights component.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ResourceName <String>]: The name of the Application Insights component resource.
  [StorageType <StorageType?>]: The type of the Application Insights component data source for the linked storage account.
  [SubscriptionId <String>]: The ID of the target subscription.
  [WebTestName <String>]: The name of the Application Insights WebTest resource.
.Link
https://docs.microsoft.com/powershell/module/az.applicationinsights/clear-azapplicationinsights
#>
function Clear-AzApplicationInsights {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='PurgeViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Purge', Mandatory)]
    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Alias('ApplicationInsightsComponentName', 'ComponentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the Application Insights component resource.
    ${Name},

    [Parameter(ParameterSetName='Purge', Mandatory)]
    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Purge')]
    [Parameter(ParameterSetName='PurgeExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='PurgeViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.IApplicationInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Purge', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PurgeViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBody]
    # Describes the body of a purge request for an App Insights component
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters[]]
    # The set of columns and filters (queries) to run over them to purge the resulting data.
    # To construct, see NOTES section for FILTER properties and create a hash table.
    ${Filter},

    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Table from which to purge data.
    ${Table},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            Purge = 'Az.ApplicationInsights.private\Clear-AzApplicationInsights_Purge';
            PurgeExpanded = 'Az.ApplicationInsights.private\Clear-AzApplicationInsights_PurgeExpanded';
            PurgeViaIdentity = 'Az.ApplicationInsights.private\Clear-AzApplicationInsights_PurgeViaIdentity';
            PurgeViaIdentityExpanded = 'Az.ApplicationInsights.private\Clear-AzApplicationInsights_PurgeViaIdentityExpanded';
        }
        if (('Purge', 'PurgeExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
