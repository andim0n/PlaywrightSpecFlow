using Microsoft.Playwright;

namespace PlaywrightWithSpecFlowDemo.Pages
{
    public class WebTablesPage
    {
        public IPage Page;
        public string URL => "https://demoqa.com/webtables";
        public ILocator Table => Page.Locator(".rt-table");
        public ILocator BtnAdd => Page.Locator("#addNewRecordButton");
        public ILocator BtnSubmit => Page.Locator("#submit");
        public ILocator FirstName => Page.Locator("#firstName");
        public ILocator LastName => Page.Locator("#lastName");
        public ILocator Email => Page.Locator("#userEmail");
        public ILocator Age => Page.Locator("#age");
        public ILocator Salary => Page.Locator("#salary");
        public ILocator Department => Page.Locator("#department");

        public WebTablesPage(IPage page)
        {
            Page = page;
        }
    }
}