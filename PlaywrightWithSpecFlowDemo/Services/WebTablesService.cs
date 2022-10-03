using PlaywrightWithSpecFlowDemo.Drivers;

namespace PlaywrightWithSpecFlowDemo.Services
{
    public class WebTablesService
    {
        private Pages.WebTablesPage _webTablesPage;

        public WebTablesService(Driver driver)
        {
            _webTablesPage = new Pages.WebTablesPage(driver.Page);
        }

        public void OpenMainPage()
        {
            _webTablesPage.Page.GotoAsync(_webTablesPage.URL).GetAwaiter().GetResult();
            _webTablesPage.Table.WaitForAsync();
        }

        public void ClickButton(string button)
        {
            if (button == "Add")
            {
                _webTablesPage.BtnAdd.ClickAsync().GetAwaiter().GetResult();
                _webTablesPage.BtnSubmit.WaitForAsync().GetAwaiter().GetResult();
            }
            else if (button == "Submit")
            {
                _webTablesPage.BtnSubmit.ClickAsync().GetAwaiter().GetResult();
            }
        }

        public void FillRegistrationForm(string firstName, string lastName, string email, string age, string salary, string department)
        {
            _webTablesPage.FirstName.FillAsync(firstName).GetAwaiter().GetResult();
            _webTablesPage.LastName.FillAsync(lastName).GetAwaiter().GetResult();
            _webTablesPage.Email.FillAsync(email).GetAwaiter().GetResult();
            _webTablesPage.Age.FillAsync(age).GetAwaiter().GetResult();
            _webTablesPage.Salary.FillAsync(salary).GetAwaiter().GetResult();
            _webTablesPage.Department.FillAsync(department).GetAwaiter().GetResult();
        }

        public void ValidateRowData(string firstName, string lastName, string email, string age, string salary, string department)
        {
            var actualFirstName = _webTablesPage.Page.Locator($".rt-td:text('{firstName}')").TextContentAsync().GetAwaiter().GetResult();
            var actualLastName = _webTablesPage.Page.Locator($".rt-td:text('{lastName}')").TextContentAsync().GetAwaiter().GetResult();
            var actualEmail = _webTablesPage.Page.Locator($".rt-td:has-text('{email}')").TextContentAsync().GetAwaiter().GetResult();
            var actualAge = _webTablesPage.Page.Locator($".rt-td:has-text('{age}')").TextContentAsync().GetAwaiter().GetResult();
            var actualSalary = _webTablesPage.Page.Locator($".rt-td:has-text('{salary}')").TextContentAsync().GetAwaiter().GetResult();
            var actualDepartment = _webTablesPage.Page.Locator($".rt-td:has-text('{department}')").TextContentAsync().GetAwaiter().GetResult();

            actualFirstName.Should().Be(firstName);
            actualLastName.Should().Be(lastName);
            actualEmail.Should().Be(email);
            actualAge.Should().Be(age);
            actualSalary.Should().Be(salary);
            actualDepartment.Should().Be(department);
        }
    }
}
