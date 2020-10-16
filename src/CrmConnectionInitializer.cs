﻿namespace Springboard365.Tools.DynamicsCrm.Common
{
    using System;
    using System.Configuration;
    using System.ServiceModel.Description;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using Microsoft.Xrm.Tooling.Connector;

    public class CrmConnectionInitializer
    {
        private const string ConnectionStringSettingName = "CrmConnection";

        public IOrganizationService InitialiseService()
        {
            Console.Out.WriteLine($"Initialising CRM service from Connection String with name {ConnectionStringSettingName}...");
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringSettingName].ConnectionString;
            return new CrmServiceClient(connectionString);
        }

        public IOrganizationService InitialiseService(string server, string orgName, string domain, string userName, string password)
        {
            Console.Out.WriteLine("Initialising CRM service...");

            var uri = GetCrmUri(server, orgName);

            var clientCredentials = GetClientCredentials(domain, userName, password);

            var organizationServiceProxy = new OrganizationServiceProxy(uri, null, clientCredentials, null);
            organizationServiceProxy.EnableProxyTypes();

            return organizationServiceProxy;
        }

        private static Uri GetCrmUri(string server, string orgName)
        {
            var organizationUrl = string.Format("{0}/{1}/XRMServices/2011/Organization.svc", server, orgName);
            return new Uri(organizationUrl);
        }

        private static ClientCredentials GetClientCredentials(string domain, string userName, string password)
        {
            var clientCredentials = new ClientCredentials();
            clientCredentials.Windows.ClientCredential.Domain = domain;
            clientCredentials.Windows.ClientCredential.UserName = userName;
            clientCredentials.Windows.ClientCredential.Password = password;
            return clientCredentials;
        }
    }
}