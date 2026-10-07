using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using ProjetoTesteSelenium.PageObjects.PlaygroundQaPageObjects;
using Reqnroll;

namespace ProjetoTesteSelenium.Steps
{
    [Binding]
    public class PlaygroundQaStepDefinition
    {
        private readonly PlaygroundQaActions _playgroundQaActions;

        public PlaygroundQaStepDefinition(IWebDriver webdriver)
        {
            _playgroundQaActions = new PlaygroundQaActions(webdriver);
        }

        [When("preenche o campo Título do defeito com {string}")]
        public void WhenPreencheOCampoTituloDoDefeitoCom(string TituloDefeito)
        {
            _playgroundQaActions.PreencherCampoTituloDefeito(TituloDefeito);
        }

        [When("seleciona o módulo afetado {string}")]
        public void WhenSelecionaOModuloAfetado(string modulo)
        {
            _playgroundQaActions.SelecionarModuloAfetado(modulo);
        }

        [When("seleciona a severidade {string}")]
        public void WhenSelecionaASeveridade(string tipoSeveridade)
        {
            _playgroundQaActions.SelecionarSeveridade(tipoSeveridade);
        }

        [When("seleciona o ambiente {string}")]
        public void WhenSelecionaOAmbiente(string ambiente)
        {
            _playgroundQaActions.SelecionarAmbiente(ambiente);
        }

        [When("preenche o campo E-mail de quem reportou com {string}")]
        public void WhenPreencheOCampoE_MailDeQuemReportouCom(string email)
        {
            _playgroundQaActions.PreencherCampoEmailReportou(email);
        }

        [When("informa a data de deteccao {string}")]
        public void WhenInformaADataDeDeteccao(string dataDeteccao)
        {
            _playgroundQaActions.InserirDataDeteccao(dataDeteccao);
        }

        [When("informa {string} no campo Ocorrencias")]
        public void WhenInformaNoCampoOcorrencias(string qtdOcorrencias)
        {
            _playgroundQaActions.InserirQtdOcorrencias(qtdOcorrencias);
        }

        [When("seleciona a prioridade {string}")]
        public void WhenSelecionaAPrioridade(string prioridade)
        {
            _playgroundQaActions.SelecionarPrioridade(prioridade);
        }

        [When("preenche o campo Passos para reproduzir com:")]
        public void WhenPreencheOCampoPassosParaReproduzirCom(string passosReproduzir)
        {
            _playgroundQaActions.PreencherCampoPassosReproduzir(passosReproduzir);
        }

        [When("marca a confirmacao de que o relato nao contém informacoes sensíveis")]
        public void WhenMarcaAConfirmacaoDeQueORelatoNaoContemInformacoesSensiveis()
        {
            _playgroundQaActions.MarcarConfirmacaoInformacoesSensiveis();
        }

        [When("clica no botao {string}")]
        public void WhenClicaNoBotao(string nomeBotao)
        {
            _playgroundQaActions.ClicarBotaoDoPainelRegistrar(nomeBotao);
        }

        [Then("deve visualizar a mensagem {string}")]
        public void ThenDeveVisualizarAMensagem(string mensagem)
        {
            _playgroundQaActions.VerificarMensagemSucesso(mensagem);
        }
    }
}