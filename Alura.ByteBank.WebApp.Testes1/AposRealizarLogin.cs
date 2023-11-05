using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.WebApp.Testes1
{
    public class AposRealizarLogin
    {
        [Fact]
        public void AposRealizarLoginVeerificaSeExisteOpcaoAgenciaMenu()
        {
            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl("https://localhost:44309/");

            var login = driver.FindElement(By.Id("Email"));
            var senha = driver.FindElement(By.Id("Senha"));
            var btnLogar = driver.FindElement(By.Id("btn-logar"));

            login.SendKeys("andre@gmail.com");
            senha.SendKeys("senha01");

            //Act
            btnLogar.Click();


            //Assert
            Assert.Contains("Agência", driver.PageSource); 



        }
        [Fact]

        public void TentaRealizarLoginSemPreencherOsCampos()
        {
            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl("https://localhost:44309/");

            var login = driver.FindElement(By.Id("Email"));
            var senha = driver.FindElement(By.Id("Senha"));
            var btnLogar = driver.FindElement(By.Id("btn-logar"));

           

            //Act
            btnLogar.Click();


            //Assert
            Assert.Contains("The Email field is required", driver.PageSource);
            Assert.Contains("The Senha field is required", driver.PageSource);


        }

        [Fact]

        public void TentaRealizarLoginComSenhaInvalida()
        {
            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl("https://localhost:44309/");

            var login = driver.FindElement(By.Id("Email"));
            var senha = driver.FindElement(By.Id("Senha"));
            var btnLogar = driver.FindElement(By.Id("btn-logar"));


            login.SendKeys("andre@gmail.com");
            senha.SendKeys("senha010");

            //Act
            btnLogar.Click();


            //Assert
            Assert.Contains("Login", driver.PageSource);



        }

        [Fact]
        public void TentaAcessarPaginaSemEstarLogado()
        {
            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl("https://localhost:44309/");

            Assert.Contains("401", driver.PageSource);
        }

        [Fact]
        public void RealizaLoginAcessaMenuECadastraCliente()
        {

            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");

            var login = driver.FindElement(By.Name("Email"));
            var senha = driver.FindElement(By.Name("Senha"));

            login.SendKeys("andre@email.com");
            senha.SendKeys("senha01");
        }
    }
}
