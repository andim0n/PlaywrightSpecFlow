using UiAutomationCore.UI.BasePage;
using UiAutomationCore.UI.BaseElement;
using UiAutomationCore.UI.WrappedElements;

namespace UiAutomationDemo.Pages
{
    public class WebTablesPage : BasePage
    {
        public WebTablesPage() : base("https://demoqa.com/webtables") { }
        public Element Table => Find<Element>(".rt-table");
        public Button BtnAdd => Find<Button>("#addNewRecordButton");
        public Button BtnSubmit => Find<Button>("#submit");
        public TextBox FirstName => Find<TextBox>("#firstName");
        public TextBox LastName => Find<TextBox>("#lastName");
        public TextBox Email => Find<TextBox>("#userEmail");
        public TextBox Age => Find<TextBox>("#age");
        public TextBox Salary => Find<TextBox>("#salary");
        public TextBox Department => Find<TextBox>("#department");
    }
}