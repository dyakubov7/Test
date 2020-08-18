using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       IWebDriver driver = new ChromeDriver(@"C:\Users\dyakubov\Downloads\chromedriver_win32");
        

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://google.com");
            driver.Quit();
        }
    }
}
