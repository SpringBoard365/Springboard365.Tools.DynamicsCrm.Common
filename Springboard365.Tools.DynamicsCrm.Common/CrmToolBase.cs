namespace Springboard365.DynamicsCrm.Tools.Common
{
    using Microsoft.Xrm.Sdk;
    using Springboard365.Tools.CommandLine.Core;

    public abstract class CrmToolBase : CommandLineProgramBase
    {
        protected internal CrmToolBase(CommandLineParameterBase commandLineParameterBase, string[] args)
            : base(commandLineParameterBase, args)
        {
            var crmCommandLineParameterBase = (CrmCommandLineParameterBase)CommandLineParameterBase;

            OrganizationService = new CrmConnectionInitializer().InitialiseService(
                crmCommandLineParameterBase.ServerUrl,
                crmCommandLineParameterBase.OrganizationName,
                crmCommandLineParameterBase.DomainName,
                crmCommandLineParameterBase.UserName,
                crmCommandLineParameterBase.Password);
        }

        public IOrganizationService OrganizationService { get; set; }

        public abstract void Run();

        public override void RunBase()
        {
            Run();
        }
    }
}