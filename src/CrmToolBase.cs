namespace Springboard365.Tools.DynamicsCrm.Common
{
    using System.Net;
    using Microsoft.Crm.Sdk.Messages;
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

            if (!string.IsNullOrWhiteSpace(crmCommandLineParameterBase.ConnectionString))
            {
                OrganizationService = new CrmConnectionInitializer().InitialiseService(crmCommandLineParameterBase.ConnectionString);
            }
            else
            {
                const string ConnectionStringSettingName = "CrmConnection";
                OrganizationService = new CrmConnectionInitializer().InitialiseServiceFromConnectionStringSetting(ConnectionStringSettingName);
            }

            OrganizationService.Execute(new WhoAmIRequest());

            Initialize();
            Run();
        }
    }
}