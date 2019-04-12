namespace ForceFeedback.Core.adapters.configuration
{
    class ConfigurationProvider
    {
        private readonly Configuration _config;

        public ConfigurationProvider(string solutionFilePath, string projectFilePath, string sourceFilePath) {
            _config = new Configuration(new Configuration.Rule[0]);
        }
        
        
        internal ConfigurationProvider(Configuration config) { _config = config; }


        public Configuration Compile() {
            return _config;
        }
    }
}