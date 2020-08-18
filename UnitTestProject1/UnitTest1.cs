using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       IWebDriver driver = new ChromeDriver(@"C:\Users\dyakubov\Downloads\chromedriver_win32");
        

        [TestMethod]
        public void TestMethod1()
        {
            //navigating to google.com
            driver.Navigate().GoToUrl("https://google.com");
            
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("United shore");
            element.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.Quit();
            //quitting the browser
            //adding more comments
            

        }

        [TestMethod]

        public void test2()
        {
            driver.Navigate().GoToUrl("https://uwm.com");
            driver.Manage().Window.Maximize();
            IWebElement manageYourPipeline = driver.FindElement(By.XPath("//a[.='Manage Your Pipeline']"));
            manageYourPipeline.Click();
            IWebElement blink = driver.FindElement(By.XPath("//a[@href='https://www.uwm.com/manage-your-pipeline/blink']"));
            blink.Click();
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}
