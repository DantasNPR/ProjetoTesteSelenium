using OpenQA.Selenium;
using ProjetoTesteSelenium.Drivers;
using System;
using OpenQA.Selenium;
using ProjetoTesteSelenium.Config;
using ProjetoTesteSelenium.Drivers;

namespace ProjetoTesteSelenium.Fixtures
{
    public class WebDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; }

        public WebDriverFixture()
        {
            var settings = ConfigurationManager.Settings;

            var browser = Enum.Parse<BrowserType>(
                settings.Browser,
                ignoreCase: true);

            Driver = DriverFactory.CreateDriver(
                browser,
                settings.Headless);

            if (!settings.Headless)
            {
                Driver.Manage().Window.Maximize();
            }

            Driver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(settings.Timeout);
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
