$PSVersionTable.PSVersion
Start-JNetPS -Verbose -IgnoreUnrecognized -JVMPath $args[0]
$var = New-JObject -Class java.lang.String -Arguments "Hello from"
$var.ToString()
$var = $var.concat(" JNetPS")
$var.ToString()