#
# Module manifest for module 'MASES.JNetPS'
#
# Generated by: MASES s.r.l.
#

@{

RootModule = 'MASES.JNetPS.psm1'

ModuleVersion = '1.4.9'

# CompatiblePSEditions = @()

GUID = '799c6600-abd6-4f6d-92f1-301a056f3f1b'

Author = 'MASES s.r.l.'

CompanyName = 'MASES s.r.l.'

Copyright = 'Copyright ©  MASES s.r.l. 2022.'

Description = 'PowerShell command line interface for JNet'

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

        Tags = @('MASES.JNetPS', 'PSEdition_Core', 'PSEdition_Desktop', 'Windows', 'Linux')

        LicenseUri = 'https://github.com/masesgroup/JNet/blob/master/LICENSE'

        ProjectUri = 'https://github.com/masesgroup/JNet'

        IconUri = 'https://github.com/masesgroup/JNet/blob/master/src/net/Common/JCOB128x128.png'

        ReleaseNotes = 'https://github.com/masesgroup/JNet/releases'

    }

} 

HelpInfoURI = 'https://masesgroup.github.io/JNet/articles/usagePS.html'

# DefaultCommandPrefix = ''
}

