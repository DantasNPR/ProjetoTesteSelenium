using OpenQA.Selenium;
using ProjetoTesteSelenium.Config;
using ProjetoTesteSelenium.Fixtures;
using Reqnroll;
using Reqnroll.BoDi;

namespace ProjetoTesteSelenium.Hooks
{
    [Binding]
    public  class WebDriverHooks
    {
        private readonly IObjectContainer _container;
        private WebDriverFixture? _fixture;

        public WebDriverHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = 0)]
        public void IniciarNavegador()
        {
            _fixture = new WebDriverFixture();

            _container.RegisterInstanceAs<IWebDriver>(
                _fixture.Driver,
                dispose: false);

            _fixture.Driver.Navigate().GoToUrl(
                ConfigurationManager.Settings.BaseUrl);
        }

        [AfterScenario]
        public void FecharNavegador()
        {
            _fixture?.Dispose();
        }
    }
}