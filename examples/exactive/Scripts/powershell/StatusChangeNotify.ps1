<#
 # Copyright 2011 - 2016 Thermo Fisher Scientific Inc. or subsidiaries
 #
 # This is part of an example on how to use the API of an Exactive Series instrument
 # developed by Thermo Fisher Scientific (Bremen) GmbH.
 #
 # This file and the whole program are delivered “as is“ and without any warranty.
 #
 # Permission is granted to use this file or parts of the file for your own development, as long as there is a statement in the file header that the file has been modified, if applicable.
 #>

<#
Copyright (c) 2013 Thermo Fisher Scientific Bremen (GmbH)
This is for demonstration purposes only. Use on your on risk. Feel free to copy parts of this demonstration program.

Sample script to demonstrate how to access the Exactive Series API.

Call without any further arguments to print the current state each time it changes.

Call with one parameter (a program or batch program name) to call that program which receives the current state as its argument.

CAUTION: This script must run in 32 bit mode to link Exactive API. A typical use can be:
%windir%\SysWOW64\WindowsPowerShell\v1.0\Powershell.exe -File StatusChangeNotify.ps1 NotifyMySmartphone.bat
#>


# event handler is invoked when the connection state of the instrument has changed
$ConnectionChanged =
{
    ProcessNewState 
}

#event handler is invoked when the content of an instrument value is changed
$ContentChanged = 
{
    ProcessNewState 
}

# Return the empty string for a well-running system or a description why the system has problems.
Function EvaluateCurrentState
{
    if (-not $instrumentAccess.Connected)
    {
        # if the instrument is not connected, the connection state can be determined
        # most easily by accessing Acquisition.State.Description 
        return "Error: " + $instrumentAccess.Acquisition.State.Description
    }
    
    # instrument is connected, test the instrument general status before testing the performance.
    $rootInfoType = $root.Content.Status # 4=fatal, 3=error, 2=warning, 1=info, 0=OK
    $rootMessage = $root.Content.Content

    $performanceInfoType = $performance.Content.Status
    $performanceMessage = $performance.Content.Content

    if ($rootInfoType -ge 3)
    {
        return "Error: " + $rootMessage
    }
    if ($rootInfoType -ge 2)
    {
        return "Warning: " + $rootMessage
    }
    # accept info on root, handle errors and warnings of performance first

    if ($performanceInfoType -ge 3)
    {
        return "Error: " + $performanceMessage
    }
    if ($performanceInfoType -ge 2)
    {
        return "Warning: " + $performanceMessage
    }

    # if root still has a message that takes precedence
    if ($rootMessage -ne "")
    {
        return "Informational: " + $rootMessage
    }  
    if ($performanceMessage -ne "")
    {
        return "Informational: " + $performanceMessage
    }  

    return "";
}

# Show a new, changed instrument state (or pass it to an external program/script) when it
# has changed.
Function ProcessNewState
{
    $currentState = EvaluateCurrentState

    if ($currentState.Trim() -ne $previousState)
    {
        $previousState = $currentState.Trim()
        if ($externalProgram -eq "")
        {
            Write-Host $currentState
        }
        else
        {
            # Embrace string with double-quotes to have it transported as a single argument
            $currentState = '"' + $currentState + '"'
            Start-Process -FilePath $externalProgram -NoNewWindow -ArgumentList "$currentState"
        }
    }
}


# removes all events and event subscribers
Function Remove-EventAndSubscriber
{
    Get-EventSubscriber | Unregister-Event
    Get-Event | Remove-Event
}

$externalProgram = ""
if ($args.Length -eq 1)
{
    $externalProgram = $args[0]
}

# expect exceptions on uninstalled Exactive software or mismatching versions.
try
{
    # instantiate instrument API for the first instrument
    $instrumentAccessContainer = New-Object -ComObject "Thermo Exactive.API_Clr2_32_V1"
    # get the first instrument
    $instrumentAccess = $instrumentAccessContainer.Get(1)
        
    # print the instrument name and id
    $instrumentAccess.InstrumentName + $instrumentAccess.InstrumentId

    # initialize the current message
    $previousState = ""

    $root = $instrumentAccess.Control.InstrumentValues.Get("Root");
    $performance = $instrumentAccess.Control.InstrumentValues.Get("Performance");

    # get notified when the instrument state has been changed
    $null = Register-ObjectEvent $instrumentAccess ConnectionChanged -SourceIdentifier Instrument.ConnectionChanged -Action $ConnectionChanged
    $null = Register-ObjectEvent $root ContentChanged -SourceIdentifier InstrumentRootValue.ContentChanged -Action $ContentChanged
    $null = Register-ObjectEvent $performance ContentChanged -SourceIdentifier InstrumentPerformanceValue.ContentChanged -Action $ContentChanged

    ProcessNewState

    #just keep the script running, stop with ctrl+c
    Wait-Event -SourceIdentifier Dummy
}
catch
{
    Write-Host $Error[0].Exception   
}
finally
{
    # because the script might stop with ctrl+c the event subscribers maystill active 
    # so remove all events and event subscribers
    Remove-EventAndSubscriber
}