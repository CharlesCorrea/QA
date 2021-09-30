using OpenQA.Selenium;

namespace LoginAutomation.PageObjects
{
    /// <summary>
    /// Não consegui acesso à plataforma, portando não sei ao certo o mapeamento dos campos.
    /// Desta forma, estou dando nomes aos elementos do DOM.
    /// Estou sendo redirecionado para https://account.blip.ai/unsupported-browser
    /// </summary>
    public class LoginPO
    {
        public static By Email = By.XPath("//input[@id='email']");
        public static By Senha = By.XPath("//input[@id='senha']");

        public static By Cadastrar = By.XPath("//input[@type='submit']");
        public static By LoginSucesso = By.XPath("//span[text()='Login com sucesso.']");
    }
}
