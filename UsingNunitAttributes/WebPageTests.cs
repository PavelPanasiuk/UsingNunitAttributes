using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;


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
        public void Test1()
        {
            var closePopUp = Driver.FindElement(By.XPath("//button[@class='sign_in-exit']"));
            closePopUp.Click();

            //Find search line
            var searchLine = Driver.FindElement(By.CssSelector("[placeholder = 'Search']"));
            searchLine.Click();

            //Write text
            searchLine.SendKeys("What the");

            //Click button for starting search
            var searchButton = Driver.FindElement(By.CssSelector("#orb-search-button"));
            searchButton.Click();

            //Click first link
            var clickFirstLink = Driver.FindElement(By.XPath("//a[@class='css-vh7bxp-PromoLink e1f5wbog6'][1]"));
            clickFirstLink.Click();
        }
    }
}