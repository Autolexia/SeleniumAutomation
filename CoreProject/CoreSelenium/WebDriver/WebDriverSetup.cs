using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace CoreProject.CoreSelenium.WebDriver
{
    public class WebDriverSetup
    {
        public IWebDriver Driver { get; set; }
        public TimeSpan UrlWaitTimeInSeconds { get; set; } = TimeSpan.FromSeconds(120);

        public WebDriverSetup(string url)
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);

            Driver = new ChromeDriver();
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public bool WaitForUrlToEqual(string expectedUrl)
        {
            return new WebDriverWait(Driver, UrlWaitTimeInSeconds).Until(Driver => Driver.Url.Equals(expectedUrl));
        }
    }
}
