using System.Collections.Specialized;
using System.Configuration;

namespace rg.Configuration
{
    internal sealed class DefaultConfigurationProvider : IConfigurationProvider
    {
        public ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return ConfigurationManager.ConnectionStrings; }
        }

        public NameValueCollection AppSettings
        {
            get { return ConfigurationManager.AppSettings; }
        }
    }
}
