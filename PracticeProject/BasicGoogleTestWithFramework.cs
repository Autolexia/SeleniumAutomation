using PracticeProject.TestArtifacts;
using System;
using Xunit;

namespace PracticeProject
{
    public class BasicGoogleTestWithFramework : Google, IDisposable
    {
        [Fact]
        public void BasicSearch()
        {
            Input.SendKeys("This is a test");
            GoogleSearchButton.Click();

            Assert.True(AllTabOnResultPage.Exists());
        }

        public void Dispose()
        {
            DriverSetup.Driver.Quit();
        }
    }
}
