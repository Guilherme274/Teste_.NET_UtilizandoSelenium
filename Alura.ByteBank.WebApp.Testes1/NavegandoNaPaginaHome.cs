using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.WebApp.Testes1
{
    public class NavegandoNaPaginaHome
    {
        [Fact]
        public void CarregaPaginaHomeEVerificaTituloDaPagina()
        {
            //Arrange
            IWebDriver driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //Act
            driver.Navigate().GoToUrl("https://localhost:44309");

            //Assert
            Assert.Contains("ByteBank-WebApp", driver.Title);
        }
    }
}
