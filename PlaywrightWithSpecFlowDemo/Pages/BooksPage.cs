using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightWithSpecFlowDemo.Pages
{
    public class BooksPage
    {
        public IPage Page;
        public string URL => "https://demoqa.com/books";
        public ILocator Table => Page.Locator(".rt-tbody");
        public ILocator SearchInput => Page.Locator("#searchBox");
        public ILocator TableElement => Page.Locator(".action-buttons");
        public ILocator BookTitle => Page.Locator("#title-wrapper #userName-value");

        public BooksPage(IPage page)
        {
            Page = page;
        }
    }
}
