using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SDET47CSharp
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
        [TestMethod]
        [TestCategory("LaunchingBrowser")]
        public void FirstScript()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.google.com";
            Console.WriteLine(webDriver.Title);
            Console.WriteLine("============================================================");
            Console.WriteLine(webDriver.CurrentWindowHandle);
            Console.WriteLine("============================================================");
            Console.WriteLine(webDriver.PageSource);
            Console.WriteLine("============================================================");
            Console.WriteLine(webDriver.WindowHandles);
            Console.WriteLine("============================================================");
            Console.WriteLine(webDriver.Url);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            webDriver.Navigate().GoToUrl("https://www.facebook.com");
            webDriver.FindElement(By.XPath("//div[@class='_6ltg']/child::a")).Click();
            var ele = webDriver.FindElement(By.Id("month"));
            SelectElement selectElement = new SelectElement(ele);
            selectElement.SelectByValue("1");
            Thread.Sleep(2000);
            selectElement.SelectByValue("2");
            Thread.Sleep(2000);
            selectElement.SelectByValue("3");
            Thread.Sleep(2000);
            webDriver.Close();
            webDriver.Quit();
            webDriver.Dispose();
        }

        [Ignore]
        [TestMethod]
        [Owner("Varun")]
        [TestCategory("TestMethodInBaseClass")]
        public void TestMethod()
        {
            MessageBox.Show("This is a Test Method");
        }
    }
}
