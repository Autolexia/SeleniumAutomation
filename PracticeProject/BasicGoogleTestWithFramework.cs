using CoreProject.CoreSelenium;
using CoreProject.CoreSelenium.WebDriver;
using System;
using Xunit;

namespace PracticeProject
{
    public class BasicGoogleTestWithFramework : IDisposable
    {
        WebDriverSetup driverSetup;
        Artifact artifact;

        public TestArtifact Input { get; }

        public BasicGoogleTestWithFramework()
        {
            driverSetup = new WebDriverSetup("https://www.google.co.za");
            artifact = new Artifact(driverSetup.Driver);

            Input = artifact.Create("input");
        }

        [Fact]
        public void Test1()
        {
            Input.Type("This is a test");

            Assert.True(Input.GetValue() == "This is a test");
        }

        public void Dispose()
        {
            driverSetup.Driver.Quit();
        }
    }
}
