using RyanHelmnStore.Core.Components;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Dashboards;
using Umbraco.Web.Sections;

namespace RyanHelmnStore.Core.Composers
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class StartupComposer : IComposer
    {
        public void Compose(Composition composition)
        {
            #region Dashboards

            composition.Dashboards().Remove<ContentDashboard>();

            #endregion

            #region Sections

            // composition.Sections().Remove<FormsSection>(); // Optionally remove the forms section
            composition.Sections().Remove<TranslationSection>();
            composition.Sections().Remove<PackagesSection>();

            #endregion

            #region Components

            composition.Components().Append<BundleComponent>();

            #endregion

            #region Mappers

            #endregion
        }
    }
}