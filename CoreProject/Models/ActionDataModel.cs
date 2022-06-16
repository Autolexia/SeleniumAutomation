using OpenQA.Selenium;

namespace CoreProject.Models
{
    public class ActionDataModel
    {
        public string Selector { get; set; }
        public IWebDriver Driver { get; set; }

        public ActionDataModel(string selector, IWebDriver driver)
        {
            Selector = selector;
            Driver = driver;
        }
    }
}
