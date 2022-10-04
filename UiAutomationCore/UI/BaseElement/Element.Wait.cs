using Microsoft.Playwright;
using UiAutomationCore.Utils;

namespace UiAutomationCore.UI.BaseElement
{
    public partial class Element
    {
        public Element WaitForDisplayed()
        {
            Logger.Info($"Waiting for [{@Locator}] is Displayed");

            Locator.WaitForAsync(new LocatorWaitForOptions
            {
                State = WaitForSelectorState.Visible,
                //Timeout = ConfigManager.WaitTimeout
            }).GetAwaiter().GetResult();

            Logger.Info($"Waiting for [{@Locator}] completed successfully");
            return this;
        }

        public Element WaitForAttached()
        {
            Logger.Info($"Waiting for [{@Locator}] is Attached");

            Locator.WaitForAsync(new LocatorWaitForOptions
            {
                State = WaitForSelectorState.Attached,
                //Timeout = ConfigManager.WaitTimeout
            }).GetAwaiter().GetResult();

            Logger.Info($"Waiting for [{@Locator}] completed successfully");
            return this;
        }
    }
}