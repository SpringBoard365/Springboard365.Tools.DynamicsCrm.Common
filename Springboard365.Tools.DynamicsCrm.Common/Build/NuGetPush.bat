SET packageVersion=2.0.0-alpha02

NuGet.exe pack ../Springboard365.Tools.DynamicsCrm.Common.csproj -Build -symbols -Version %packageVersion%

NuGet.exe push Springboard365.Tools.DynamicsCrm.Common.%packageVersion%.nupkg -Source "https://api.nuget.org/v3/index.json"

pause