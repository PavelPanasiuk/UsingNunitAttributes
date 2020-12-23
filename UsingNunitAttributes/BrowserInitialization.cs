using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UsingNunitAttributes
{
    public class BrowserInitialization
    {
        public IWebDriver Driver { get; }

        public BrowserInitialization()
        {
            var browser = TestContext.Parameters.Get("browser");

            if (!Enum.TryParse(browser, out BrowserType browserType))
            {
                throw new Exception("Browser is not valid");

            }

            var baseBrowser = new BaseBrowser();
            Driver = baseBrowser.GetDriver(browserType);
        }

        [SetUp]
        public void SetUp()
        {
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
