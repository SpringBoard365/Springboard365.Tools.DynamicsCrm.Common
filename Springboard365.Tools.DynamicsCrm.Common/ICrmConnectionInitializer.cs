namespace Springboard365.DynamicsCrm.Tools.Common
{
    using Microsoft.Xrm.Sdk;

    public interface ICrmConnectionInitializer
    {
        IOrganizationService InitialiseService(string server, string orgName, string domain, string userName, string password);
    }
}