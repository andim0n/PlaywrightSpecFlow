using UiAutomationCore.UI.BaseElement;
using UiAutomationCore.Utils;
using Microsoft.Playwright;
using UiAutomationCore.Drivers;

namespace UiAutomationCore.UI.BasePage
{
    public abstract class BasePage
    {
        private IPage _page { get; set; }
        private Driver _driver;

        protected BasePage(string url)
        {
            _driver = new Driver();
            _page = _driver.Page;
            Logger.Info($"Opening new page with URL: {url}");
            _page.GotoAsync(url).GetAwaiter().GetResult();
        }
        protected BasePage()
        {
            _driver = new Driver();
            _page = _driver.Page;
        }

        public void Navigate(string url) => _page.GotoAsync(url);

        public T FindByText<T>(string locator, string text) where T : Element => (T)Activator.CreateInstance(typeof(T), _page.Locator($"{locator}:text('{text}')").First)!;

        protected T Find<T>(string locator) where T : Element => (T)Activator.CreateInstance(typeof(T), _page.Locator(locator))!;

        protected ElementsCollection<T> FindAll<T>(string locator) where T : Element
        {

            var itemsLocator = _page.Locator(locator);
            var count = itemsLocator.CountAsync().GetAwaiter().GetResult();
            var collection = new ElementsCollection<T>();
            for (int i = 0; i < count; i++) collection.Add((T)Activator.CreateInstance(typeof(T), itemsLocator.Nth(i))!);

            return collection;
        }

        protected Element Find(string locator) => (Element)Activator.CreateInstance(typeof(Element), _page.Locator(locator))!;

        protected ElementsCollection<Element> FindAll(string locator)
        {
            var itemsLocator = _page.Locator(locator);
            var count = itemsLocator.CountAsync().GetAwaiter().GetResult();
            var collection = new ElementsCollection<Element>();
            for (int i = 0; i < count; i++) collection.Add((Element)Activator.CreateInstance(typeof(Element), itemsLocator.Nth(i))!);

            return collection;
        }

        public void zoomWindow(double ratio)
        {
            _page.EvaluateAsync<string>("() => {document.body.style.zoom=" + ratio + ";}");
        }

        public string TakeScreenshot()
        {
            return Convert.ToBase64String(_page.ScreenshotAsync().GetAwaiter().GetResult());
        }
    }
}