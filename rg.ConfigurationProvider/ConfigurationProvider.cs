using System;
using System.Collections.Specialized;
using System.Configuration;

namespace rg.Configuration
{
    public static class ConfigurationProvider
    {
        #region Public properties

        /// <summary>
        /// Gets the connection strings.
        /// </summary>
        /// <value>
        /// The connection strings.
        /// </value>
        public static ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return _current.ConnectionStrings; }
        }

        /// <summary>
        /// Gets the app settings.
        /// </summary>
        /// <value>
        /// The app settings.
        /// </value>
        public static NameValueCollection AppSettings
        {
            get { return _current.AppSettings; }
        }

        #endregion

        #region Internal state (for unit testing)

        internal static IConfigurationProvider Current
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _current = value;
            }
        }

        /// <summary>
        /// Resets the default time provider.
        /// </summary>
        internal static void ResetToDefault()
        {
            _current = s_default;
        }

        #endregion

        #region Singleton pattern

        private static readonly IConfigurationProvider s_default = new DefaultConfigurationProvider();

        private static IConfigurationProvider _current = s_default;

        #endregion
    }
}