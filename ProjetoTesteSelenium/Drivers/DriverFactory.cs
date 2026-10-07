using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace ProjetoTesteSelenium.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver(
            BrowserType browser,
            bool headless = false)
        {
            return browser switch
            {
                BrowserType.Chrome => CreateChromeDriver(headless),
                BrowserType.Edge => CreateEdgeDriver(headless),
                BrowserType.Firefox => CreateFirefoxDriver(headless),

                _ => throw new ArgumentOutOfRangeException(
                    nameof(browser),
                    browser,
                    "Navegador não suportado.")
            };
        }

        private static IWebDriver CreateChromeDriver(bool headless)
        {
            var options = new ChromeOptions();

            if (headless)
            {
                options.AddArgument("--headless=new");
                options.AddArgument("--no-sandbox");
                options.AddArgument("--disable-dev-shm-usage");
                options.AddArgument("--window-size=1920,1080");
            }

            return new ChromeDriver(options);
        }

        private static IWebDriver CreateEdgeDriver(bool headless)
        {
            var options = new EdgeOptions();

            if (headless)
            {
                options.AddArgument("--headless=new");
                options.AddArgument("--window-size=1920,1080");
            }

            return new EdgeDriver(options);
        }

        private static IWebDriver CreateFirefoxDriver(bool headless)
        {
            var options = new FirefoxOptions();

            if (headless)
            {
                options.AddArgument("--headless");
            }

            return new FirefoxDriver(options);
        }
    }
}
