using RyanHelmnStore.Core.Extensions;

namespace RyanHelmnStore.Core.DocumentTypes
{
    public partial class Website
    {
        public string TitleOrDefault => Title.IfBlank(Name);
    }
}