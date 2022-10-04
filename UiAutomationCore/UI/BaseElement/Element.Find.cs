using System;

namespace UiAutomationCore.UI.BaseElement
{
    public partial class Element
    {
        public T Find <T> (string locator) where T : Element =>  (T) Activator.CreateInstance(typeof (T), Locator.Locator(locator))!;
        public ElementsCollection <T> FindAll<T>(string locator) where T : Element
        {
            var itemsLocator = Locator.Locator(locator);

            var count = itemsLocator.CountAsync().GetAwaiter().GetResult();
            var collection = new ElementsCollection <T>();
            for (int i = 0; i < count; i++)
            {
                var item = (T) Activator.CreateInstance(typeof (T), itemsLocator.Nth(i))!;
                collection.Add(item);
            }
                
            return collection;
        }

        public Element Find (string locator) => (Element) Activator.CreateInstance(typeof(Element), Locator.Locator(locator))!;
        
        public ElementsCollection <Element> FindAll (string locator)
        {
            var itemsLocator = Locator.Locator(locator);

            var count = itemsLocator.CountAsync().GetAwaiter().GetResult();
            var collection = new ElementsCollection <Element>();
            for (int i = 0; i < count; i++) collection.Add((Element) Activator.CreateInstance (typeof(Element), itemsLocator.Nth(i))!);
            return collection;
        }
    }
}