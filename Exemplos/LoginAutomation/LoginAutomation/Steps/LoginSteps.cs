using LoginAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginAutomation.Steps
{
    public class LoginSteps : TestBase
    {
        public static void InformarCampos(string email, string senha) 
        {
            driver.FindElement(LoginPO.Email).SendKeys(email);
            driver.FindElement(LoginPO.Senha).SendKeys(senha);
        }

        public static void Cadastrar() 
        {
            driver.FindElement(LoginPO.Cadastrar).Click();
        }

        public static void ValidarMensagemLoginSucesso() 
        {
            Assert.IsTrue(driver.FindElement(LoginPO.LoginSucesso).Displayed, "Mensagem não foi exibida.");
        }
    }
}
