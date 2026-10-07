\# 🧪 Automação de Testes Web com Selenium e C#

![C#](https://img.shields.io/badge/C%23-.NET-512BD4?style=for-the-badge&logo=dotnet)
![Selenium](https://img.shields.io/badge/Selenium-WebDriver-43B02A?style=for-the-badge&logo=selenium&logoColor=white)
![xUnit](https://img.shields.io/badge/Testes-xUnit-512BD4?style=for-the-badge)
![BDD](https://img.shields.io/badge/BDD-Gherkin-23D96C?style=for-the-badge&logo=cucumber&logoColor=white)


Projeto de automação de testes Web desenvolvido em \*\*C# e Selenium WebDriver\*\*, utilizando \*\*BDD com Gherkin\*\* e uma arquitetura baseada em \*\*Page Object Model (POM)\*\*.



O projeto automatiza um fluxo de \*\*registro de defeitos\*\*, simulando a interação do usuário com um formulário e validando o comportamento da aplicação após o envio.



\## 🎯 Cenário automatizado



O cenário implementado realiza o registro de um defeito no módulo de \*\*Login\*\*, contemplando o preenchimento e a seleção de diferentes informações:



\- Título do defeito;

\- Módulo afetado;

\- Severidade;

\- Ambiente;

\- E-mail de quem reportou;

\- Data de detecção;

\- Quantidade de ocorrências;

\- Prioridade;

\- Passos para reprodução;

\- Confirmação de ausência de informações sensíveis;

\- Envio do formulário;

\- Validação da mensagem de sucesso.



Ao final da execução, o teste verifica se a aplicação apresenta a confirmação de que o defeito foi registrado com sucesso.



## 🥒 Cenário BDD

O comportamento do teste é descrito em **Gherkin**, tornando o cenário legível e aproximando a especificação do comportamento esperado da aplicação.

```gherkin
# language: pt

Funcionalidade: Registro de defeitos

@TelaRegistroDefeito
Cenário: Registrar defeito no módulo Login com severidade baixa e prioridade P1 em produção
  Dado que o usuário está na aba "Playground QA" com o formulário de registro de defeitos disponível
  Quando preenche o campo Título do defeito com "Defeito de exemplo"
  E seleciona o módulo afetado "Login"
  E seleciona a severidade "Baixa"
  E seleciona o ambiente "Produção"
  E preenche o campo E-mail de quem reportou com "voce@empresa.com"
  E informa a data de deteccao "01/01/2023"
  E informa "1" no campo Ocorrencias
  E seleciona a prioridade "P1"
  E preenche o campo Passos para reproduzir com:
    """
    1. Acessar a tela X
    2. Preencher o campo Y
    3. Observar o resultado Z
    """
  E marca a confirmacao de que o relato nao contém informacoes sensíveis
  E clica no botao "Registrar defeito"
  Então deve visualizar a mensagem 'Defeito registrado com sucesso. Ele já aparece na aba "Tabela de defeitos".'
```



\## 🚀 Tecnologias utilizadas



\- C#

\- .NET

\- Selenium WebDriver

\- xUnit

\- Reqnroll

\- Gherkin

\- BDD

\- Page Object Model



\## 📁 Estrutura do projeto



```text

ProjetoTesteSelenium/

│

├── Config/

│   ├── appsettings.json

│   ├── ConfigurationManager.cs

│   └── TestSettings.cs

│

├── Drivers/

│   ├── BrowserType.cs

│   └── DriverFactory.cs

│

├── Features/

│   └── RegistroDefeito.feature

│

├── Fixtures/

│   └── WebDriverFixture.cs

│

├── Hooks/

│   └── WebDriverHooks.cs

│

├── PageObjects/

│   ├── AComunidadePageObjects/

│   └── PlaygroundQaPageObjects/

│

├── Steps/

│   ├── AComunidadeStepDefinition.cs

│   └── PlaygroundQaStepDefinition.cs

│

└── Tests/

&#x20;   └── BaseTest.cs

```



\## 🏗️ Arquitetura



O projeto foi estruturado buscando \*\*separação de responsabilidades, reutilização de código e facilidade de manutenção\*\*.



\### Config



Centraliza as configurações utilizadas durante a execução dos testes.



O `appsettings.json` armazena os parâmetros de configuração e as classes `ConfigurationManager` e `TestSettings` são responsáveis por disponibilizar essas informações para o restante da automação.



\### Drivers



Responsável pela criação e configuração do \*\*WebDriver\*\*.



A `DriverFactory` centraliza a criação das instâncias dos navegadores e o `BrowserType` representa os browsers disponíveis para execução.



\### Features



Contém os cenários de teste escritos em \*\*Gherkin\*\*.



A feature `RegistroDefeito.feature` descreve o comportamento esperado durante o preenchimento e envio do formulário de registro de defeitos.



\### Fixtures



O `WebDriverFixture` concentra o gerenciamento do WebDriver e dos recursos compartilhados durante a execução dos testes.



\### Hooks



O `WebDriverHooks` executa ações relacionadas ao ciclo de vida dos cenários, permitindo preparar e finalizar os recursos necessários para cada execução.



\### PageObjects



A camada de Page Objects encapsula os elementos e comportamentos das páginas utilizadas na automação.



A estrutura separa:



\- \*\*ElementsMap\*\* — mapeamento dos elementos da interface;

\- \*\*Actions\*\* — ações executadas sobre esses elementos.



Essa separação reduz duplicação e facilita alterações futuras nos localizadores.



\### Steps



Contém as implementações dos passos definidos nos cenários BDD.



Os Step Definitions fazem a ligação entre os comandos escritos em \*\*Gherkin\*\* e as ações implementadas nos Page Objects.



\### Tests



Contém estruturas base reutilizadas pelos testes automatizados, como a classe `BaseTest`.



\## 💡 Conceitos aplicados



Neste projeto foram aplicados conceitos importantes de automação e qualidade de software:



\- Automação de testes Web;

\- Selenium WebDriver;

\- BDD;

\- Gherkin;

\- Page Object Model;

\- Step Definitions;

\- Fixtures;

\- Hooks;

\- Driver Factory;

\- Separação entre elementos e ações;

\- Reutilização de código;

\- Validação do comportamento esperado;

\- Organização de um framework de automação.



\## 👨‍💻 Autor



\*\*Angelo Daniel Dantas\*\*



QA Automation | C# | .NET | Selenium | Playwright

