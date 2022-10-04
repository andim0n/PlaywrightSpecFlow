using UiAutomationCore.Utils;

namespace UiAutomationCore.UI.BaseElement
{
    public partial class Element
    {
        public void Click ()
        {
            Locator.First.ClickAsync().GetAwaiter().GetResult();
            //Logger.Info($"[{@Locator}] was clicked");
        }
    }
}