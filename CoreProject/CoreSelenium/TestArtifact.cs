using CoreProject.CoreSelenium.TestActions;
using OpenQA.Selenium;

namespace CoreProject.CoreSelenium
{
    public class TestArtifact : BaseActions
    {
        public TestArtifact(string selector, IWebDriver driver) : base(selector, driver) { }

        public void Click() => new Click(ActionData.Selector, ActionData.Driver);

        public void TryClick() => new TryClick(ActionData.Selector, ActionData.Driver);

        public void Type(string value) => new Type(ActionData.Selector, ActionData.Driver, value);

        public bool Exists() => new Exists(ActionData.Selector, ActionData.Driver).IsTrue;

        public string GetText() => new GetText(ActionData.Selector, ActionData.Driver).Value;

        public string GetValue() => new GetValue(ActionData.Selector, ActionData.Driver).Value;
    }
}
