using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Amazon_Automation
{
    class Program
    {
        // Create a reference for chrome browser - ("Create a chrome driver")
        IWebDriver driver = new ChromeDriver();

 
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            // Go to Amazon page 
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

        [Test]
        public void ExecuteTest()
        {
            // Make the browser full screen
            driver.Manage().Window.Maximize();

            // Web Elements

            // Sign-in "button"
            IWebElement SignIn = driver.FindElement(By.Id("nav-link-accountList"));
            
            //CLick the sign in button 
            SignIn.Click();

            // Find Email type in box 
            IWebElement EmailField = driver.FindElement(By.Id("ap_email"));
            
            // Send email to email field
            EmailField.SendKeys("pewpew@abv.hg");

            // Find Continue button
            IWebElement ContinueButton = driver.FindElement(By.Id("continue"));
            
            // CLick continue button
            ContinueButton.Click();

            
            // Find Alert heading "there was a problem" 
            IWebElement ErrorMessage = driver.FindElement(By.ClassName("a-alert-heading"));

            // Create variable for actual result and expected result 
            string ActualErrorMessageText = ErrorMessage.Text;
            string ExpectedErrorMessageText = "There was a problem";

            // Assert to compare the variables to check if the actual result matches with the expected result 
            Assert.AreEqual(ActualErrorMessageText, ExpectedErrorMessageText);


        }

        [TearDown]
        public void CloseTest()
        {
            // Close the browser
            driver.Quit();
        }
    }
}
