using System.Text.RegularExpressions;
namespace BlogShare.Helper
{
    public static class RemoveHtmlTagHel
    {
        public static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>|&.*?;", string.Empty);

        }
    }
}