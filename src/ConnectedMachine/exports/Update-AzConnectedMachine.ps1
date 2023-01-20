
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
The operation to update a hybrid machine.
.Description
The operation to update a hybrid machine.
.Example
Update-AzConnectedMachine -Name surface -ResourceGroupName rg -PrivateLinkScopeResourceId privateLinkScopeId -WindowsConfigurationPatchSettingsAssessmentMode AutomaticByOS -Tag @{"key"="value"}
.Example
Update-AzConnectedMachine -Name surface -ResourceGroupName rg -PrivateLinkScopeResourceId $null

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdate
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachine
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedMachineIdentity>: Identity Parameter
  [ExtensionName <String>]: The name of the machine extension.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [Location <String>]: The location of the target resource.
  [MachineName <String>]: The name of the hybrid machine.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [PrivateLinkScopeId <String>]: The id (Guid) of the Azure Arc PrivateLinkScope resource.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScopeName <String>]: The name of the Azure Arc PrivateLinkScope resource.
  [SubscriptionId <String>]: The ID of the target subscription.

PARAMETER <IMachineUpdate>: Describes a hybrid machine Update.
  [Tag <IResourceUpdateTags>]: Resource tags
    [(Any) <String>]: This indicates any property can be added to this object.
  [IdentityType <ResourceIdentityType?>]: The identity type.
  [LinuxConfigurationPatchSettingsAssessmentMode <AssessmentModeTypes?>]: Specifies the assessment mode.
  [LinuxConfigurationPatchSettingsPatchMode <PatchModeTypes?>]: Specifies the patch mode.
  [LocationDataCity <String>]: The city or locality where the resource is located.
  [LocationDataCountryOrRegion <String>]: The country or region where the resource is located
  [LocationDataDistrict <String>]: The district, state, or province where the resource is located.
  [LocationDataName <String>]: A canonical name for the geographic or physical location.
  [ParentClusterResourceId <String>]: The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
  [PrivateLinkScopeResourceId <String>]: The resource id of the private link scope this machine is assigned to, if any.
  [WindowsConfigurationPatchSettingsAssessmentMode <AssessmentModeTypes?>]: Specifies the assessment mode.
  [WindowsConfigurationPatchSettingsPatchMode <PatchModeTypes?>]: Specifies the patch mode.
.Link
https://learn.microsoft.com/powershell/module/az.connectedmachine/update-azconnectedmachine
#>
function Update-AzConnectedMachine {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachine])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('MachineName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [System.String]
    # The name of the hybrid machine.
    ${Name},

    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [ArgumentCompleter({Get-AzResourceGroup | Select-Object -ExpandProperty ResourceGroupName})]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Update')]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IMachineUpdate]
    # Describes a hybrid machine Update.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.ResourceIdentityType]
    # The identity type.
    ${IdentityType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes]
    # Specifies the assessment mode.
    ${LinuxConfigurationPatchSettingsAssessmentMode},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes]
    # Specifies the patch mode.
    ${LinuxConfigurationPatchSettingsPatchMode},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The city or locality where the resource is located.
    ${LocationDataCity},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The country or region where the resource is located
    ${LocationDataCountryOrRegion},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The district, state, or province where the resource is located.
    ${LocationDataDistrict},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # A canonical name for the geographic or physical location.
    ${LocationDataName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
    ${ParentClusterResourceId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The resource id of the private link scope this machine is assigned to, if any.
    ${PrivateLinkScopeResourceId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20220310.IResourceUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.AssessmentModeTypes]
    # Specifies the assessment mode.
    ${WindowsConfigurationPatchSettingsAssessmentMode},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PatchModeTypes]
    # Specifies the patch mode.
    ${WindowsConfigurationPatchSettingsPatchMode},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
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

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            Update = 'Az.ConnectedMachine.private\Update-AzConnectedMachine_Update';
            UpdateExpanded = 'Az.ConnectedMachine.private\Update-AzConnectedMachine_UpdateExpanded';
            UpdateViaIdentity = 'Az.ConnectedMachine.private\Update-AzConnectedMachine_UpdateViaIdentity';
            UpdateViaIdentityExpanded = 'Az.ConnectedMachine.private\Update-AzConnectedMachine_UpdateViaIdentityExpanded';
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
