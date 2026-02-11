param(
    [string]$JVMPath
)

$PSVersionTable.PSVersion
Write-Host "Executing using JVM in $JVMPath"
Start-JNetPS -Verbose -JVMPath $JVMPath
$var = New-JObject -Class java.lang.String -Arguments "Hello from"
$var.ToString()
$var = $var.concat(" JNetPS")
$var.ToString()