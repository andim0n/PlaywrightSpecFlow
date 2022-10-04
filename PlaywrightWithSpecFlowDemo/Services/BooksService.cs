using UiAutomationDemo.Pages;

namespace UiAutomationDemo.Services
{
    public class BooksService : PageProvider<BooksPage>
    {

        public void OpenMainPage()
        {
            Page.Table.WaitForDisplayed();
        }

        public void InputText(string text)
        {
            Page.SearchInput.Fill(text);
        }

        public void SelectFirstElement()
        {
            Page.BookTitle.Click();
        }

        public void ValidateDescription(string text)
        {
            Page.BookDescription.Text.Should().Be(text);
        }
    }
}
