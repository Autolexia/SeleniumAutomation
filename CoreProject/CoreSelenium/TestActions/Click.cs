using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CoreProject.CoreSelenium.TestActions
{
    public class Click : BaseActions
    {
        public Click(string selector, IWebDriver driver) : base(selector, driver)
        {
            new Actions(ActionData.Driver)
                .Click(Element())
                .Perform();
        }
    }
}
