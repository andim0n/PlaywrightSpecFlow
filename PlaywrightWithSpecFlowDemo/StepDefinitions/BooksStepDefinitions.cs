using PlaywrightWithSpecFlowDemo.Drivers;
using PlaywrightWithSpecFlowDemo.Services;

namespace PlaywrightWithSpecFlowDemo.StepDefinitions
{
    [Binding]
    public class BooksStepDefinitions
    {
        private readonly Driver _driver;
        private readonly BooksService _booksService;

        public BooksStepDefinitions(Driver driver)
        {
            _driver = driver;
            _booksService = new BooksService(_driver);
        }

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
            _booksService.ValidateTitle(text);
        }
    }
}
