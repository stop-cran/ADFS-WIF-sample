using System.IdentityModel.Configuration;

namespace AdfsWifSample
{
    public static class ClaimsHelper
    {
        public static string TrustedIssuer
        {
            get
            {
                return SystemIdentityModelSection.Current.IdentityConfigurationElements
                    .GetElement("")
                    .IssuerNameRegistry
                    .ChildNodes[0]
                    .SelectSingleNode("//authority")
                    .Attributes["name"].Value;
            }
        }
    }
}