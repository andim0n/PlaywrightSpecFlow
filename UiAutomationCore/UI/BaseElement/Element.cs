//using UiAutomationCore.UI.Browser;
using Microsoft.Playwright;

namespace UiAutomationCore.UI.BaseElement
{
    public partial class Element
    {
        public readonly ILocator Locator;
        //protected IMouse Mouse => BrowserFactory.BrowserInstance.Mouse;
        public Element (ILocator locator) => Locator = locator;

        public string Text => Locator.InnerTextAsync().GetAwaiter().GetResult();
        public string GetText => Locator.TextContentAsync().GetAwaiter().GetResult();
        public bool Displayed => Locator.IsVisibleAsync().GetAwaiter().GetResult();
        public bool Enabled => Locator.IsEnabledAsync().GetAwaiter().GetResult();
        public bool Editable => Locator.IsEditableAsync().GetAwaiter().GetResult();
        public string? GetAttribute (string attribute) => Locator.GetAttributeAsync(attribute).GetAwaiter().GetResult();
    }
}