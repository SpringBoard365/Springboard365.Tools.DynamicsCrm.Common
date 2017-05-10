namespace Springboard365.Tools.DynamicsCrm.Common
{
    using Microsoft.Xrm.Sdk;

    public interface ICrmConnectionInitializer
    {
        IOrganizationService InitialiseService(string server, string orgName, string domain, string userName, string password);
    }
}