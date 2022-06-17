using CoreProject.CoreSelenium;
using CoreProject.CoreSelenium.WebDriver;

namespace PracticeProject.TestArtifacts
{
    public class Google
    {
        Artifact artifact;

        public WebDriverSetup DriverSetup { get; }
        public TestArtifact Input { get; }
        public TestArtifact GoogleSearchButton { get; }
        public TestArtifact AllTabOnResultPage { get; }

        public Google()
        {
            DriverSetup = new WebDriverSetup("https://www.google.co.za");
            artifact = new Artifact(DriverSetup.Driver);

            Input = artifact.Create("input");
            GoogleSearchButton = artifact.Create(".FPdoLc [value='Google Search']");
            AllTabOnResultPage = artifact.Create(".hdtb-mitem.hdtb-msel > span");
        }
    }
}
