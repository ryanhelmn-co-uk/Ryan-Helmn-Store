using StackExchange.Profiling.Internal;

namespace RyanHelmnStore.Core.Extensions
{
    public static class StringExtensions
    {
        public static string IfBlank(this string original, string replacement)
        {
            return original.IsNullOrWhiteSpace() ? replacement : original;
        }
    }
}