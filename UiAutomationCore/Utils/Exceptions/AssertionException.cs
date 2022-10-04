using System.Text;

namespace UiAutomationCore.Utils.Exceptions
{
    public class AssertionException : Exception
    {
        public AssertionException(List<string> assertsMessages)
            : base($"\nAsserts fails:\n{GetFormattedLog(assertsMessages)}")
        {
        }

        private static string GetFormattedLog(List<string> assertsMessages)
        {
            var stringBuilder = new StringBuilder();
            assertsMessages.ForEach(message => stringBuilder.AppendLine(message));
            return stringBuilder.ToString();
        }
    }
}