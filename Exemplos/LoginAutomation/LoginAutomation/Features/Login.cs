using LoginAutomation.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginAutomation.Features
{
    [TestClass]
    public class Login : TestBase
    {
        [TestMethod]
        public void LoginComSucesso() 
        {
            LoginSteps.InformarCampos("user@email.com", "123456");
            LoginSteps.Cadastrar();
            LoginSteps.ValidarMensagemLoginSucesso();
        }
    }
}
