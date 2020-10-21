namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Springboard365.Tools.CommandLine.Core;

    public class CrmCommandLineParameterBase : CommandLineParameterBase
    {
        [CommandLineArgument(ArgumentType.Optional, "ConnectionString", Description = "Show the connection string.", Shortcut = "con")]
        public string ConnectionString { get; set; }
    }
}