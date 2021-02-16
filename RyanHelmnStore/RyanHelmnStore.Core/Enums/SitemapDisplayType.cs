using System.ComponentModel.DataAnnotations;

namespace RyanHelmnStore.Core.Enums
{
    public enum SitemapDisplayType
    {
        Include = 0,
        [Display(Name = "Exclude Self")] ExcludeSelf = 1,
        [Display(Name = "Exclude Self and Children")] ExcludeSelfAndChildren = 2
    }
}
