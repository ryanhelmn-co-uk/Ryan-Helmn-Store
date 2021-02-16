using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web.Models;

namespace RyanHelmnStore.Core.Extensions
{
    public static class UmbracoLinkExtensions
    {
        public static IHtmlString RenderLink(this Link link, string classes = "", string innerText = "")
        {
            var linkTag = new TagBuilder("a");
            if (!link.Target.IsNullOrWhiteSpace())
            {
                linkTag.MergeAttribute("target", link.Target);
            }

            if (!classes.IsNullOrWhiteSpace())
            {
                linkTag.MergeAttribute("class", classes);
            }

            if (!innerText.IsNullOrWhiteSpace())
            {
                linkTag.InnerHtml = innerText;
            }
            else
            {
                linkTag.SetInnerText(link.Name);
            }

            linkTag.MergeAttribute("href", link.Url);

            return new HtmlString(linkTag.ToString());
        }
    }
}