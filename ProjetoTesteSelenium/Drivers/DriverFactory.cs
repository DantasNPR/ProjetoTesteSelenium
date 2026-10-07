using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver(BrowserType browser)
        {
            return browser switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Edge => new EdgeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),

                _ => throw new ArgumentOutOfRangeException(
                    nameof(browser),
                    browser,
                    "Navegador não suportado.")
            };
        }
    }
}
