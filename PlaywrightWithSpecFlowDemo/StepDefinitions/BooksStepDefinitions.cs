using UiAutomationDemo.Services;

namespace UiAutomationDemo.StepDefinitions
{
    [Binding]
    public class BooksStepDefinitions
    {
        private BooksService _booksService = new BooksService();

        [StepDefinition(@"The Books page is open")]
        public void ThePageIsOpen()
        {
            _booksService.OpenMainPage();
        }

        [StepDefinition(@"Text '([^']*)' is applied as a search filter")]
        public void GivenTextIsAppliedAsASearchFilter(string text)
        {
            _booksService.InputText(text);
        }

        [StepDefinition(@"I select first found result")]
        public void WhenISelectFirstFoundedResult()
        {
            _booksService.SelectFirstElement();
        }

        [StepDefinition(@"The title should contain text '([^']*)'")]
        public void ThenTheTitleShouldContainText(string text)
        {
            _booksService.ValidateDescription(text);
        }
    }
}
