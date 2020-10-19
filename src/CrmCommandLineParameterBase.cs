namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Springboard365.Tools.CommandLine.Core;

    public class CrmCommandLineParameterBase : CommandLineParameterBase
    {
        [CommandLineArgument(ArgumentType.Optional, "ServerUrl", Description = "Show the server url.", Shortcut = "url")]
        public string ServerUrl { get; set; }

        [CommandLineArgument(ArgumentType.Optional, "OrganizationName", Description = "Show the organization name.", Shortcut = "orgname")]
        public string OrganizationName { get; set; }

        [CommandLineArgument(ArgumentType.Optional, "Domain", Description = "Show the domain name.", Shortcut = "d")]
        public string DomainName { get; set; }

        [CommandLineArgument(ArgumentType.Optional, "Username", Description = "Show the user name.", Shortcut = "u")]
        public string UserName { get; set; }

        [CommandLineArgument(ArgumentType.Optional, "Password", Description = "Show the password.", Shortcut = "p")]
        public string Password { get; set; }
    }
}