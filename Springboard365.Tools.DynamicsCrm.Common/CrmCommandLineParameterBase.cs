namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Springboard365.Tools.CommandLine.Core;

    public class CrmCommandLineParameterBase : CommandLineParameterBase
    {
        [CommandLineArgument(ArgumentType.Required, "ServerUrl", Description = "Show the server url.", Shortcut = "url")]
        public string ServerUrl { get; set; }

        [CommandLineArgument(ArgumentType.Required, "OrganizationName", Description = "Show the organization name.", Shortcut = "orgname")]
        public string OrganizationName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Domain", Description = "Show the domain name.", Shortcut = "d")]
        public string DomainName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Username", Description = "Show the user name.", Shortcut = "u")]
        public string UserName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Password", Description = "Show the password.", Shortcut = "p")]
        public string Password { get; set; }
    }
}
