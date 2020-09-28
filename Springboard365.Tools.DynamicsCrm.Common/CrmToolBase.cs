namespace Springboard365.Tools.DynamicsCrm.Common
{
    using System.Net;
    using Microsoft.Xrm.Sdk;
    using Springboard365.Tools.CommandLine.Core;

    public abstract class CrmToolBase : CommandLineProgramBase
    {
        protected internal CrmToolBase(CommandLineParameterBase commandLineParameterBase, string[] args)
            : base(commandLineParameterBase, args)
        {
        }

        public IOrganizationService OrganizationService { get; set; }

        public virtual void Initialize()
        {
        }

        public abstract void Run();

        public override void RunBase()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var crmCommandLineParameterBase = (CrmCommandLineParameterBase)CommandLineParameterBase;

            var allStrings = string.Join(string.Empty, crmCommandLineParameterBase.ServerUrl, crmCommandLineParameterBase.OrganizationName, crmCommandLineParameterBase.DomainName, crmCommandLineParameterBase.UserName, crmCommandLineParameterBase.Password);
            if (string.IsNullOrWhiteSpace(allStrings))
            {
                OrganizationService = new CrmConnectionInitializer().InitialiseService();
            }
            else
            {
                OrganizationService = new CrmConnectionInitializer().InitialiseService(
                    crmCommandLineParameterBase.ServerUrl,
                    crmCommandLineParameterBase.OrganizationName,
                    crmCommandLineParameterBase.DomainName,
                    crmCommandLineParameterBase.UserName,
                    crmCommandLineParameterBase.Password);
            }

            Initialize();
            Run();
        }
    }
}