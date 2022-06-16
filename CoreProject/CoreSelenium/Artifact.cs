using OpenQA.Selenium;

namespace CoreProject.CoreSelenium
{
    public class Artifact
    {
        public IWebDriver Driver { get; set; }

        public Artifact(IWebDriver driver)
        {
            Driver = driver;
        }

        public TestArtifact Create(string selector)
        {
            return new TestArtifact(selector, Driver);
        }
    }
}
