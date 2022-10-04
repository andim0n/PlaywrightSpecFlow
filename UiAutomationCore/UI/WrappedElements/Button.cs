using Microsoft.Playwright;
using UiAutomationCore.UI.BaseElement;

namespace UiAutomationCore.UI.WrappedElements
{
    public class Button : Element
    {
        public Button(ILocator locator) : base(locator) { }
    }
}