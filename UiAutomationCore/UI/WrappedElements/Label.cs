using Microsoft.Playwright;
using UiAutomationCore.UI.BaseElement;

namespace UiAutomationCore.UI.WrappedElements
{
    public class Label : Element
    {
        public Label(ILocator locator) : base(locator) { }
    }
}