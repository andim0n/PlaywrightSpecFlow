using UiAutomationCore.Utils;
using Microsoft.Playwright;
using UiAutomationCore.UI.BaseElement;

namespace UiAutomationCore.UI.WrappedElements
{
    public class TextBox : Element
    {
        public TextBox(ILocator locator) : base(locator) { }

        public void Fill(string text, bool provideConfirmation = false)
        {
            Locator.FillAsync(text).GetAwaiter().GetResult();
            if (provideConfirmation)
            {
                Locator.PressAsync("Enter").GetAwaiter().GetResult();
            }
            Logger.Info($"[{@Locator}] was filled by [{text}]");
        }
    }
}