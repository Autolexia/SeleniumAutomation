using OpenQA.Selenium;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class TryClick : BaseActions
    {
        public TryClick(string selector, IWebDriver driver) : base(selector, driver)
        {
            if (new Exists(ActionData.Selector, ActionData.Driver).IsTrue)
                new Click(selector, driver);
        }
    }
}
