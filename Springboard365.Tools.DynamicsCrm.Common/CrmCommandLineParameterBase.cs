namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Springboard365.Tools.CommandLine.Core;

    public class CrmCommandLineParameterBase : CommandLineParameterBase
    {
        [CommandLineArgument(ArgumentType.Required, "Server Url", Description = "Show the server url.", Shortcut = "serverurl")]
        public string ServerUrl { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Organization Name", Description = "Show the organization name.", Shortcut = "orgname")]
        public string OrganizationName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Domain Name", Description = "Show the domain name.", Shortcut = "domain")]
        public string DomainName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "User Name", Description = "Show the user name.", Shortcut = "username")]
        public string UserName { get; set; }

        [CommandLineArgument(ArgumentType.Required, "Password", Description = "Show the password.", Shortcut = "pwd")]
        public string Password { get; set; }
    }
}
