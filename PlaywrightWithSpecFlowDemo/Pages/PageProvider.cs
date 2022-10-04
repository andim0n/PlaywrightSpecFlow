using UiAutomationCore.UI.BasePage;

namespace UiAutomationDemo.Pages
{
    public abstract class PageProvider<TPage> where TPage : BasePage
    {
        private TPage _page;
        protected TPage Page => _page ??= Activator.CreateInstance<TPage>();
    }
}