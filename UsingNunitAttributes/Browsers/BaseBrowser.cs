using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace UsingNunitAttributes
{
    public class BaseBrowser
    {
        public IWebDriver GetDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver();
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                default:
                    throw new Exception("This browser is not supported.");
            }

        }
    }
}
