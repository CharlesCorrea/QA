using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace LoginAutomation
{
    public class TestBase
    {
        public static ChromeDriver driver;
        public const string baseUrl = "https://www.login.com.br";

        [TestInitialize]
        public static void Initialize() 
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();

            // Setando o timeout para 10 segundos.
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        [TestCleanup]
        public static void CleanUp()
        {
            // Fecha o brwoser e destroi a instância do ChromeDriver.
            driver.Quit();
        }
    }
}
