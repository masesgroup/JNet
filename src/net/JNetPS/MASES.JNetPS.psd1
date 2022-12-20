#
# Module manifest for module 'MASES.JNetPS'
#
# Generated by: MASES s.r.l.
#

@{

RootModule = 'MASES.JNetPS.psm1'

ModuleVersion = '1.4.15'

# CompatiblePSEditions = @()

GUID = '82FBF86C-1604-4940-84D1-993CC42D7853'

Author = 'MASES s.r.l.'

CompanyName = 'MASES s.r.l.'

Copyright = 'Copyright ©  MASES s.r.l. 2022'

Description = 'JNet PowerShell (aka JNetPS) is a PowerShell Module to use JVM and PowerShell side-by-side. With JNetPS it is possible to:
- create and use JVM objects from PowerShell: initialize JVM object (Java, Scala, Kotlin, ...), execute mehods on the object, read data from the object to be used for further PowerShell code 
- send to JVM objects data managed from PowerShell: e.g. data of PowerShell, like an input from command-line or a variable, can be used as an argument for the initialization or execution of a method of a JVM object

More information within the project hosted on GitHub at https://github.com/masesgroup/JNet for further information.'

# PowerShellVersion = ''

# PowerShellHostName = ''

# PowerShellHostVersion = ''

# DotNetFrameworkVersion = ''

# CLRVersion = ''

# ProcessorArchitecture = ''

# RequiredModules = @()

# RequiredAssemblies = @()

# ScriptsToProcess = @()

# TypesToProcess = @()

# FormatsToProcess = @()

# NestedModules = @()

FunctionsToExport = @()

CmdletsToExport = @(
    'Start-JNetPS',
    'Invoke-JCommand',
    'New-JObject'
)

VariablesToExport = '*'

AliasesToExport = @()

# DscResourcesToExport = @()

# ModuleList = @()

# FileList = @()

PrivateData = @{

    PSData = @{

        Tags = @('JNetPS', 'JNet', 'PSEdition_Core', 'PSEdition_Desktop', 'Windows', 'Linux', 'JVM', 'Java', 'Scala', 'Kotlin', 'bridge', 'gateway')

        LicenseUri = 'https://github.com/masesgroup/JNet/blob/master/LICENSE'

        ProjectUri = 'https://github.com/masesgroup/JNet'

        IconUri = 'https://raw.githubusercontent.com/masesgroup/JNet/master/src/net/Common/JCOB128x128.png'

        ReleaseNotes = 'https://github.com/masesgroup/JNet/releases'

    }
} 

HelpInfoURI = 'https://masesgroup.github.io/JNet/articles/usagePS.html'

# DefaultCommandPrefix = ''
}

