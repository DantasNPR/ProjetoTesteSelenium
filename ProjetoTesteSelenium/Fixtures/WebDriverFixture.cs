using OpenQA.Selenium;
using ProjetoTesteSelenium.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.Fixtures
{
    public class WebDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; }

        public WebDriverFixture()
        {
            Driver = DriverFactory.CreateDriver(BrowserType.Chrome);

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
