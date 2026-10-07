using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTesteSelenium.PageObjects.PlaygroundQaPageObjects
{
    class PlaygroundQaElementsMap
    {
        public static By TituloDefeito => By.Id("campo-titulo");
        public static By CampoEmailReportado => By.Id("campo-reporter");
        public static By CampoOcorrencias => By.Id("campo-ocorrencias");
        public static By CampoPassosReproduzir => By.Id("campo-passos");
        public static By InformacoesSensiveis => By.Id("campo-aceite");
    }
}
