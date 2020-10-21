namespace Springboard365.Tools.DynamicsCrm.Common
{
    using System;
    using System.Configuration;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Tooling.Connector;

    public class CrmConnectionInitializer
    {
        public IOrganizationService InitialiseService(string connectionString)
        {
            Console.Out.WriteLine($"Initialising CRM service from parameter Connection String...");
            return new CrmServiceClient(connectionString);
        }

        public IOrganizationService InitialiseServiceFromConnectionStringSetting(string connectionStringSettingName)
        {
            Console.Out.WriteLine($"Initialising CRM service from Connection String setting with name: '{connectionStringSettingName}'...");
            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringSettingName].ConnectionString;

            return new CrmServiceClient(connectionString);
        }
    }
}