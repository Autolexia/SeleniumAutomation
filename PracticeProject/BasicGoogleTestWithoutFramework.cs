using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using Xunit;

namespace PracticeProject
{
    public class BasicGoogleTestWithoutFramework : IDisposable
    {

        public IWebDriver Driver { get; set; }

        public BasicGoogleTestWithoutFramework()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);

            Driver = new ChromeDriver();
            Driver.Url = "https://www.google.co.za";
            Driver.Manage().Window.Maximize();
        }

        [Fact]
        public void BasicSearch()
        {
            var input = Driver.FindElement(By.CssSelector("input"));
            input.SendKeys("This is a test");

            var googleSearchButton = Driver.FindElement(By.CssSelector(".FPdoLc [value='Google Search']"));
            googleSearchButton.Click();

            Driver.FindElement(By.CssSelector(".hdtb-mitem.hdtb-msel > span"));
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
