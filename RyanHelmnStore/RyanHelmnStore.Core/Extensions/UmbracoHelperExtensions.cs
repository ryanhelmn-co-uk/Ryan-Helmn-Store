using System;
using System.Collections.Generic;
using System.Linq;
using RyanHelmnStore.Core.DocumentTypes;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace RyanHelmnStore.Core.Extensions
{
    public static class UmbracoHelperExtensions
    {
        public static Website Website(this UmbracoHelper umbracoHelper)
        {
            return GetCurrentWebsite(umbracoHelper);
        }

        private static Website GetCurrentWebsite(UmbracoHelper umbracoHelper)
        {
            var websites = umbracoHelper.ContentAtRoot().OfType<Website>().ToList();

            if (websites.Count == 1)
            {
                return websites.FirstOrDefault();
            }

            try
            {
                // assignedContentItem doesn't return null, just throws YSOD
                var currentPage = umbracoHelper.AssignedContentItem;
                return currentPage.Root() as Website;
            }
            catch (Exception)
            {
                // Ignored
            }

            // TODO Figure out alternative way to get website at root node, by domain?
            return null;
        }

        /// <summary>
        ///     Grabs the first descendant of the content type under the current website
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="umbracoHelper"></param>
        /// <returns></returns>
        public static T SingleContentOfType<T>(this UmbracoHelper umbracoHelper)
            where T : class, IPublishedContent
        {
            var website = GetCurrentWebsite(umbracoHelper);
            return website.Descendants<T>().FirstOrDefault();
        }

        /// <summary>
        ///     Grabs the first descendant of the content type under the website
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="umbracoHelper"></param>
        /// <param name="website"></param>
        /// <returns></returns>
        public static T SingleContentOfType<T>(this UmbracoHelper umbracoHelper, Website website)
            where T : class, IPublishedContent
        {
            return website.Descendants<T>().FirstOrDefault();
        }

        /// <summary>
        ///     Grabs all of the descendents of the content type under the current website
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="umbracoHelper"></param>
        /// <returns></returns>
        public static IEnumerable<T> ContentOfType<T>(this UmbracoHelper umbracoHelper)
            where T : class, IPublishedContent
        {
            var website = GetCurrentWebsite(umbracoHelper);
            return website.Descendants<T>();
        }

        /// <summary>
        ///     Grabs all of the descendents of the content type under the given website
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="umbracoHelper"></param>
        /// <param name="website"></param>
        /// <returns></returns>
        public static IEnumerable<T> ContentOfType<T>(this UmbracoHelper umbracoHelper, Website website)
            where T : class, IPublishedContent
        {
            return website.Descendants<T>();
        }
    }
}