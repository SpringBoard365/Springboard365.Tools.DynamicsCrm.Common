namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Microsoft.Xrm.Sdk;
    using Springboard365.Tools.CommandLine.Core;

    public abstract class CrmToolBase : CommandLineProgramBase
    {
        protected internal CrmToolBase(CommandLineParameterBase commandLineParameterBase, string[] args)
            : base(commandLineParameterBase, args)
        {
        }

        public IOrganizationService OrganizationService { get; set; }

        public abstract void Initialize();

        public abstract void Run();

        public override void RunBase()
        {
            var crmCommandLineParameterBase = (CrmCommandLineParameterBase)CommandLineParameterBase;

            OrganizationService = new CrmConnectionInitializer().InitialiseService(
                crmCommandLineParameterBase.ServerUrl,
                crmCommandLineParameterBase.OrganizationName,
                crmCommandLineParameterBase.DomainName,
                crmCommandLineParameterBase.UserName,
                crmCommandLineParameterBase.Password);

            Initialize();
            Run();
        }
    }
}