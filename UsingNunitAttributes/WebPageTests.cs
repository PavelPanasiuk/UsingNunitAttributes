using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;

namespace UsingNunitAttributes
{
    [TestFixture]
    public class TestingWebPage : BrowserInitialization
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void GoToGoogle_EnterText_ClickFirstLink()
        {
            //Find search
            var searchLine = Driver.FindElement(By.CssSelector("[name = 'q']"));
            searchLine.Click();

            //Write text
            searchLine.SendKeys("What the hell is going on.");

            //Click button for starting search
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(elem => elem.FindElement(By.XPath("//span[contains(text(),'what the hell is going on')][1]"))).Click();               
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Click first link
            WebDriverWait wait1 = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            try
            {
                wait1.Until(elem => elem.FindElement(By.XPath("//h3/span[contains(text(),'what the')][1]"))).Click();
                //firstLinkInSearchResult.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}