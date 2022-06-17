using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class SendKeys : BaseActions
    {
        public SendKeys(string selector, IWebDriver driver, string value) : base(selector, driver)
        {
            new Actions(ActionData.Driver)
                .SendKeys(Element(), value)
                .Perform();
        }
    }
}
