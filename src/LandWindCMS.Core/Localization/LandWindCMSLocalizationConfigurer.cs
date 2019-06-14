using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LandWindCMS.Localization
{
    public static class LandWindCMSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LandWindCMSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LandWindCMSLocalizationConfigurer).GetAssembly(),
                        "LandWindCMS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
