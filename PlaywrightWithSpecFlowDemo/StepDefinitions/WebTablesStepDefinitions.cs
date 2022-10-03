using PlaywrightWithSpecFlowDemo.Drivers;
using PlaywrightWithSpecFlowDemo.Services;

namespace PlaywrightWithSpecFlowDemo.StepDefinitions
{
    [Binding]
    public sealed class WebTablesStepDefinitions
    {
        private readonly Driver _driver;
        private readonly WebTablesService _webTablesService;

        public WebTablesStepDefinitions(Driver driver)
        {
            _driver = driver;
            _webTablesService = new WebTablesService(_driver);
        }

        [StepDefinition(@"The '([^']*)' page is open")]
        public void ThePageIsOpen(string page)
        {
            if (page == "WebTables")
            {
                _webTablesService.OpenMainPage();
            }
        }

        [StepDefinition(@"Click '([^']*)' button")]
        public void ClickButton(string button)
        {
            _webTablesService.ClickButton(button);
        }

        [StepDefinition(@"I insert values '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in the registration form")]
        public void InsertValuesInTheRegistrationForm(string firstName, string lastName, string email, string age, string salary, string department)
        {
            _webTablesService.FillRegistrationForm(firstName, lastName, email, age, salary, department);
        }

        [StepDefinition(@"I should be able to see the row with data '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in the table")]
        public void ShouldBeAbleToSeeNewRowWithDataInTheTable(string firstName, string lastName, string email, string age, string salary, string department)
        {
            _webTablesService.ValidateRowData(firstName, lastName, email, age, salary, department);
        }
    }
}
