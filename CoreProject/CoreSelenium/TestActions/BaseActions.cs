using CoreProject.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace CoreProject.CoreSelenium.TestActions
{
    public class BaseActions
    {
        public ActionDataModel ActionData { get; }
        public WebDriverWait WaitAction { get; set; }
        public TimeSpan WaitTime { get; set; } = TimeSpan.FromSeconds(120);

        public BaseActions(string selector, IWebDriver driver)
        {
            ActionData = new ActionDataModel(selector, driver);

            WaitAction = new WebDriverWait(ActionData.Driver, WaitTime);
            WaitAction.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void Wait() => WaitAction.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(ActionData.Selector)));

        public IWebElement Element()
        {
            Wait();
            return ActionData.Driver.FindElement(By.CssSelector(ActionData.Selector));
        }
    }
}
