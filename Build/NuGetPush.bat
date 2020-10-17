@echo off
SET packageVersion=2.0.1-beta01

SET configuration=Release
SET id="Springboard365.Tools.DynamicsCrm.Common";
SET author="Springboard 365 Ltd";
SET repo="https://github.com/SpringBoard365/Springboard365.Tools.DynamicsCrm.Common";
SET description="The common project to create command line tools for Dynamics Crm.";
SET tags="CommandLine Springboard365ToolHelper PowerPlatformToolHelper Dynamics365ToolHelper DynamicsCrmToolHelper";

dotnet build ../src/DynamicsCrm.Common.csproj -c  %configuration% -p:Version=%packageVersion% -f net462 --nologo

pause

NuGet.exe pack ../src/DynamicsCrm.Common.nuspec -Build -symbols -Version %packageVersion% -Properties Configuration=%configuration%;id=%id%;author=%author%;repo=%repo%;description=%description%;tags=%tags%;

NuGet.exe push Springboard365.Tools.DynamicsCrm.Common.%packageVersion%.nupkg -Source "https://api.nuget.org/v3/index.json"

pause