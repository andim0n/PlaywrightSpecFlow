using UiAutomationCore.UI.BaseElement;
using UiAutomationDemo.Pages;

namespace UiAutomationDemo.Services
{
    public class WebTablesService : PageProvider<WebTablesPage>
    {

        public void OpenMainPage()
        {
            Page.Table.WaitForDisplayed();
        }

        public void ClickButton(string button)
        {
            if (button == "Add")
            {
                Page.BtnAdd.Click();
                Page.BtnSubmit.WaitForDisplayed();
            }
            else if (button == "Submit")
            {
                Page.BtnSubmit.Click();
            }
        }

        public void FillRegistrationForm(string firstName, string lastName, string email, string age, string salary, string department)
        {
            Page.FirstName.Fill(firstName);
            Page.LastName.Fill(lastName);
            Page.Email.Fill(email);
            Page.Age.Fill(age);
            Page.Salary.Fill(salary);
            Page.Department.Fill(department);
        }

        public void ValidateRowData(string firstName, string lastName, string email, string age, string salary, string department)
        {
            var actualFirstName = Page.FindByText<Element>(".rt-td", firstName).GetText;
            var actualLastName = Page.FindByText<Element>(".rt-td", firstName).GetText;
            var actualEmail = Page.FindByText<Element>(".rt-td", firstName).GetText;
            var actualAge = Page.FindByText<Element>(".rt-td", firstName).GetText;
            var actualSalary = Page.FindByText<Element>(".rt-td", firstName).GetText;
            var actualDepartment = Page.FindByText<Element>(".rt-td", firstName).GetText;

            //var actualFirstName = Page.Locator($".rt-td:text('{firstName}')").TextContentAsync().GetAwaiter().GetResult();
            //var actualLastName = Page.Page.Locator($".rt-td:text('{lastName}')").TextContentAsync().GetAwaiter().GetResult();
            //var actualEmail = Page.Page.Locator($".rt-td:has-text('{email}')").TextContentAsync().GetAwaiter().GetResult();
            //var actualAge = Page.Page.Locator($".rt-td:has-text('{age}')").TextContentAsync().GetAwaiter().GetResult();
            //var actualSalary = Page.Page.Locator($".rt-td:has-text('{salary}')").TextContentAsync().GetAwaiter().GetResult();
            //var actualDepartment = Page.Page.Locator($".rt-td:has-text('{department}')").TextContentAsync().GetAwaiter().GetResult();

            actualFirstName.Should().Be(firstName);
            actualLastName.Should().Be(lastName);
            actualEmail.Should().Be(email);
            actualAge.Should().Be(age);
            actualSalary.Should().Be(salary);
            actualDepartment.Should().Be(department);
        }
    }
}
