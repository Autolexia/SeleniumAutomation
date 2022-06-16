using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class Type : BaseActions
    {
        public Type(string selector, IWebDriver driver, string value) : base(selector, driver)
        {
            new Actions(ActionData.Driver)
                .SendKeys(Element(), value)
                .Perform();
        }
    }
}
