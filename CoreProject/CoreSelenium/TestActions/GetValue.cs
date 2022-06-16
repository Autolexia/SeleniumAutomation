using OpenQA.Selenium;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class GetValue : BaseActions
    {
        public string Value { get; }

        public GetValue(string selector, IWebDriver driver) : base(selector, driver)
        {
            Value = Element().GetAttribute("value");
        }
    }
}
