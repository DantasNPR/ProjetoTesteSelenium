using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoTesteSelenium.PageObjects.PlaygroundQaPageObjects
{
    public class PlaygroundQaActions
    {
        private readonly IWebDriver Driver;

        public PlaygroundQaActions(IWebDriver driver)
        {
            Driver = driver
                ?? throw new ArgumentNullException(nameof(driver));
        }

        public void PreencherCampoTituloDefeito(string tituloDefeito)
        {
            try
            {
                Driver.FindElement(PlaygroundQaElementsMap.TituloDefeito).SendKeys(tituloDefeito);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao preencher o campo 'Título do defeito': {e.Message}", e);
            }
        }

        public void SelecionarModuloAfetado(string modulo)
        {
            try
            {
                // Lógica para selecionar o módulo afetado com base no nome fornecido
                // Exemplo: Localizar o elemento do módulo e clicar nele
                var elemento = Driver.FindElement(By.Id("campo-modulo"));
                var select = new SelectElement(elemento);
                select.SelectByText(modulo);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao selecionar o módulo afetado '{modulo}': {e.Message}", e);
            }
        }

        public void SelecionarSeveridade(string tipoSeveridade)
        {
            try
            {
                // Lógica para selecionar a severidade com base no nome fornecido
                // Exemplo: Localizar o elemento da severidade e clicar nele
                var elemento = Driver.FindElement(By.Id("campo-severidade"));
                var select = new SelectElement(elemento);
                select.SelectByText(tipoSeveridade);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao selecionar a severidade '{tipoSeveridade}': {e.Message}", e);
            }
        }

        public void SelecionarAmbiente(string ambiente)
        {
            try
            {
                // Lógica para selecionar o ambiente com base no nome fornecido
                // Exemplo: Localizar o elemento do ambiente e clicar nele
                var elemento = Driver.FindElement(By.Id("campo-ambiente"));
                var select = new SelectElement(elemento);
                select.SelectByText(ambiente);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao selecionar o ambiente '{ambiente}': {e.Message}", e);
            }
        }

        public void PreencherCampoEmailReportou(string email)
        {
            try
            {
                Driver.FindElement(PlaygroundQaElementsMap.CampoEmailReportado).SendKeys(email);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao preencher o campo 'E-mail de quem reportou': {e.Message}", e);
            }
        }

        public void InserirDataDeteccao(string dataDeteccao)
        {
            try
            {
                var campo = Driver.FindElement(By.Id("campo-data"));

                campo.Clear();
                campo.SendKeys(dataDeteccao);
                //campo.SendKeys(Keys.Tab);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir a data de detecção '{dataDeteccao}': {e.Message}", e);
            }
        }

        public void InserirQtdOcorrencias(string QtdOcorrencias)
        {
            try
            {
                Driver.FindElement(PlaygroundQaElementsMap.CampoOcorrencias).SendKeys(QtdOcorrencias);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao inserir a quantidade de ocorrências '{QtdOcorrencias}': {e.Message}", e);
            }
        }

        public void SelecionarPrioridade(string prioridade)
        {
            try
            {
                // Lógica para selecionar a prioridade com base no nome fornecido
                // Exemplo: Localizar o elemento da prioridade e clicar nele
                var elemento = Driver.FindElement(By.CssSelector($"input[type='radio'][name='prioridade'][value='{prioridade}']"));

                if (!elemento.Selected)
                {
                    elemento.Click();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao selecionar a prioridade '{prioridade}': {e.Message}", e);
            }
        }

        public void PreencherCampoPassosReproduzir(string passosReproduzir)
        {
            try
            {
                Driver.FindElement(PlaygroundQaElementsMap.CampoPassosReproduzir).SendKeys(passosReproduzir);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao preencher o campo 'Passos para reproduzir': {e.Message}", e);
            }
        }

        public void MarcarConfirmacaoInformacoesSensiveis()
        {
            try
            {
                Driver.FindElement(PlaygroundQaElementsMap.InformacoesSensiveis).Click();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao marcar a confirmacao de que o relato nao contém informacoes sensíveis: {e.Message}", e);
            }
        }

        public void ClicarBotaoDoPainelRegistrar(string nomeBotao)
        {
            try
            {
                // Lógica para clicar no botão com base no nome fornecido
                // Exemplo: Localizar o elemento do botão e clicar nele
                var botao = Driver.FindElement(By.XPath($"//div[@id='painel-registrar']//div//button[text()='{nomeBotao}']"));
                botao.Click();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao clicar no botão '{nomeBotao}': {e.Message}", e);
            }
        }

        public void VerificarMensagemSucesso(string mensagem)
        {
            try
            {
                // Lógica para verificar a mensagem de sucesso
                // Exemplo: Localizar o elemento da mensagem e verificar seu texto
                var elementoMensagem = Driver.FindElement(By.XPath($"//div//span[text()='{mensagem}']"));
                var textoMensagem = elementoMensagem.Text;
                if (!textoMensagem.Contains(mensagem))
                {
                    throw new Exception($"A mensagem de sucesso esperada '{mensagem}' não foi encontrada. Mensagem atual: '{textoMensagem}'");
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao verificar a mensagem de sucesso '{mensagem}': {e.Message}", e);
            }
        }
    }
}
