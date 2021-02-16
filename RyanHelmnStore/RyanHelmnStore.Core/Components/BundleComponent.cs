using System.Web.Mvc;
using ClientDependency.Core;
using Umbraco.Core.Composing;

namespace RyanHelmnStore.Core.Components
{
    public class BundleComponent : IComponent
    {
        public void Initialize()
        {
            AreaRegistration.RegisterAllAreas();
            CreateBundles();
        }

        public void Terminate()
        {
            // Not implemented
        }

        private static void CreateBundles()
        {
            BundleManager.CreateCssBundle("css",
                new CssFile("~/assets/vendor/bootstrap/css/bootstrap.min.css"),
                new CssFile("~/assets/vendor/lightbox2/css/lightbox.min.css"),
                new CssFile("~/assets/vendor/nouislider/nouislider.min.css"),
                new CssFile("~/assets/vendor/bootstrap-select/css/bootstrap-select.min.css"),
                new CssFile("~/assets/vendor/owl.carousel2/assets/owl.carousel.min.css"),
                new CssFile("~/assets/vendor/owl.carousel2/assets/owl.theme.default.css"),
                new CssFile("~/assets/css/style.default.css"),
                new CssFile("~/assets/css/custom.css")
            );

            BundleManager.CreateJsBundle("js",
                new JavascriptFile("~/assets/vendor/jquery/jquery.min.js"),
                new JavascriptFile("~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js"),
                new JavascriptFile("~/assets/vendor/lightbox2/js/lightbox.min.js"),
                new JavascriptFile("~/assets/vendor/nouislider/nouislider.min.js"),
                new JavascriptFile("~/assets/vendor/bootstrap-select/js/bootstrap-select.min.js"),
                new JavascriptFile("~/assets/vendor/owl.carousel2/owl.carousel.min.js"),
                new JavascriptFile("~/assets/vendor/owl.carousel2.thumbs/owl.carousel2.thumbs.min.js"),
                new JavascriptFile("~/assets/js/front.js"));
        }
    }
}