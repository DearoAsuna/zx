using Microsoft.Extensions.Configuration;


namespace Json1
{
    public class FxConfigSourse: FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new FxconfigProvider(this);
        }
    }
}
