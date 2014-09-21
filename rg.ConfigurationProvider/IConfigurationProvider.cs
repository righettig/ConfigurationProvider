using System.Collections.Specialized;
using System.Configuration;

namespace rg.Configuration
{
    public interface IConfigurationProvider
    {
        /// <summary>
        /// Gets the connection strings.
        /// </summary>
        /// <value>
        /// The connection strings.
        /// </value>
        ConnectionStringSettingsCollection ConnectionStrings { get; }

        /// <summary>
        /// Gets the app settings.
        /// </summary>
        /// <value>
        /// The app settings.
        /// </value>
        NameValueCollection AppSettings { get; }
    }
}