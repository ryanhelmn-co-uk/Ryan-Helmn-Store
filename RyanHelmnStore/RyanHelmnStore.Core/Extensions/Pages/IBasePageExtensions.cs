using RyanHelmnStore.Core.DocumentTypes;
using RyanHelmnStore.Core.Enums;
using RyanHelmnStore.Core.Helpers;

namespace RyanHelmnStore.Core.Extensions.Pages
{
    public static class IBasePageExtensions
    {
        public static string MetaTitleOrDefault(this IBasePage basePage)
        {
            return basePage.MetaTitle.IfBlank(basePage.Name);
        }

        public static SitemapDisplayType SitemapDisplayType(this IBasePage basePage)
        {
            return EnumHelper<SitemapDisplayType>.GetValueFromName(basePage.XmlSitemapDisplay);
        }
    }
}