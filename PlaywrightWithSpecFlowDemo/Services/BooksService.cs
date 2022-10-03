using PlaywrightWithSpecFlowDemo.Drivers;
using PlaywrightWithSpecFlowDemo.Pages;

namespace PlaywrightWithSpecFlowDemo.Services
{
    public class BooksService
    {
        private BooksPage _booksPage;

        public BooksService(Driver driver)
        {
            _booksPage = new BooksPage(driver.Page);
        }

        public void OpenMainPage()
        {
            _booksPage.Page.GotoAsync(_booksPage.URL).GetAwaiter().GetResult();
            _booksPage.Table.WaitForAsync().GetAwaiter().GetResult();
        }

        public void InputText(string text)
        {
            _booksPage.SearchInput.FillAsync(text).GetAwaiter().GetResult();
        }

        public void SelectFirstElement()
        {
            _booksPage.TableElement.First.ClickAsync().GetAwaiter().GetResult();
        }

        public void ValidateTitle(string text)
        {
            _booksPage.BookTitle.InnerTextAsync().GetAwaiter().GetResult().Should().Be(text);
        }
    }
}
