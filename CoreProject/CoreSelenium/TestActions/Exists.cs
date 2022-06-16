using OpenQA.Selenium;

namespace CoreProject.CoreSelenium.TestActions
{
    internal class Exists : BaseActions
    {
        public bool IsTrue { get; }

        public Exists(string selector, IWebDriver driver) : base(selector, driver)
        {
            try
            {
                Element();
                IsTrue = true;
            }
            catch (NoSuchElementException)
            {
                IsTrue =  false;
            }
        }
    }
}
