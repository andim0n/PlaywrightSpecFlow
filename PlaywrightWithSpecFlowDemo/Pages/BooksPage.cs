using UiAutomationCore.UI.BaseElement;
using UiAutomationCore.UI.BasePage;
using UiAutomationCore.UI.WrappedElements;

namespace UiAutomationDemo.Pages
{
    public class BooksPage : BasePage
    {
        public BooksPage() : base("https://demoqa.com/books") { }
        public Element Table => Find<Element>(".rt-tbody");
        public TextBox SearchInput => Find<TextBox>("#searchBox");
        public Button BookTitle => Find<Button>(".action-buttons");
        public Element BookDescription => Find<Element>("#title-wrapper #userName-value");
    }
}
