using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.PageObjects.AComunidadePageObjects
{
    public class AComunidadeActions
    {
        private readonly IWebDriver Driver;

        public AComunidadeActions(IWebDriver driver)
        {
            Driver = driver
                ?? throw new ArgumentNullException(nameof(driver));
        }

        public void SelecionarAba(string nomeAba)
        {
            try
            {
                // Lógica para selecionar a aba com base no nome fornecido
                // Exemplo: Localizar o elemento da aba e clicar nele
                var aba = Driver.FindElement(By.XPath($"//div//header//a[text()='{nomeAba}']"));
                aba.Click();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao selecionar a aba '{nomeAba}': {e.Message}", e);
            }
        }
    }
}
