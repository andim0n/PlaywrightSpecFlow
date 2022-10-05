using UiAutomationDemo.Services;

namespace UiAutomationDemo.StepDefinitions
{
    [Binding]
    public sealed class WebTablesStepDefinitions
    {
        private WebTablesService _webTablesService = new WebTablesService();

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
            if (button is null)
            {
                throw new ArgumentNullException(nameof(button));
            }
            else if (button == "Add")
            {
                _webTablesService.ClickAddButton();
            }
            else if (button == "Submit")
            {
                _webTablesService.ClickSubmitButton();
            }
        }

        [StepDefinition(@"I insert values '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in the registration form")]
        public void InsertValuesInTheRegistrationForm(string firstName, string lastName, string email, string age, string salary, string department)
        {
            _webTablesService.FillRegistrationForm(firstName, lastName, email, age, salary, department);
        }

        [StepDefinition(@"I should be able to see new row with data '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in the table")]
        public void ShouldBeAbleToSeeNewRowWithDataInTheTable(string firstName, string lastName, string email, string age, string salary, string department)
        {
            _webTablesService.ValidateRowData(firstName, lastName, email, age, salary, department);
        }
    }
}
