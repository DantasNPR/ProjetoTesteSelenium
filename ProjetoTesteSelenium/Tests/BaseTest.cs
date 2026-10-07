using OpenQA.Selenium;
using ProjetoTesteSelenium.Fixtures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.Tests
{
    public abstract class BaseTest : IClassFixture<WebDriverFixture>
    {
        protected IWebDriver Driver { get; }

        protected BaseTest(WebDriverFixture fixture)
        {
            Driver = fixture.Driver;
        }
    }
}
