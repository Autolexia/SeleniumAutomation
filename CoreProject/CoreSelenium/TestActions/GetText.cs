using OpenQA.Selenium;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class GetText : BaseActions
    {
        public string Value { get; }

        public GetText(string selector, IWebDriver driver) : base(selector, driver)
        {
            Value = Element().Text;
        }
    }
}
