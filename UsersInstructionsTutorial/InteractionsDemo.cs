using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace UsersInstructionsTutorial
{

    [TestFixture]
     public class InteractionsDemo
    {
        [Test]
        public void Example1()
        {
            IWebDriver driver = new FirefoxDriver();
           
            driver.Url = "http://www.facebook.com";
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            driver.Quit();

        }
    }
}
