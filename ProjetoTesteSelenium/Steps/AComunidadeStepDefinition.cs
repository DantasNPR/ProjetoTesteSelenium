using OpenQA.Selenium;
using ProjetoTesteSelenium.PageObjects.AComunidadePageObjects;
using ProjetoTesteSelenium.PageObjects.PlaygroundQaPageObjects;
using Reqnroll;

namespace ProjetoTesteSelenium.Steps
{
    [Binding]
    public class AComunidadeStepDefinition
    {
        private readonly AComunidadeActions _acomunidadeActions;

        public AComunidadeStepDefinition(IWebDriver webDriver)
        {
            _acomunidadeActions = new AComunidadeActions(webDriver);
        }

        [Given("que o usuário está na aba {string} com o formulário de registro de defeitos disponível")]
        public void GivenQueOUsuarioEstaNaAbaComOFormularioDeRegistroDeDefeitosDisponivel(string nomeAba)
        {
            _acomunidadeActions.SelecionarAba(nomeAba);
        }
    }
}