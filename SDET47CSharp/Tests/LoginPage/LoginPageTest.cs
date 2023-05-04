using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SDET47CSharp.Object_Repo.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDET47CSharp.Object_Repo.LoginPage;
using SDET47CSharp.Generic.Utilities;

namespace SDET47CSharp.Tests.LoginPage
{
    [TestClass]
    public class LoginPageTest
    {
        IWebDriver driver;
        LoginPageElements loginPageElements;
        IWebDriverUtilities webDriverUtilities;

        string url = "http://localhost:8888/";
        string username = "admin";
        string password = "admin";
        string expectedHomePageTitle = "Administrator - Home - vtiger CRM 5 - Commercial Open Source CRM";
        string actualHomePageTitle;

        [TestMethod]
        [TestCategory("LoginPage")]
        public void VerficationOfHomePageTitleTest()
        {   
            webDriverUtilities.ImplicitlyWaitingInSeconds(driver, 10);
            Console.WriteLine( "waiting Imp Condition" );

            webDriverUtilities.MaximizeTheBrowser(driver);
            Console.WriteLine("maximizing the browser");

            driver.Navigate().GoToUrl(url);
            Console.WriteLine( "Url Loaded" );
            
            loginPageElements.Login(username, password);
            Console.WriteLine("Loging in as admin");

            webDriverUtilities.ExplicitlyWaitingTillTitleContains(driver, 10, "Home");
            Console.WriteLine( "Waiting Exp Condition" );
            
            actualHomePageTitle = driver.Title;
            Assert.AreEqual(expectedHomePageTitle, actualHomePageTitle,"The Title Was "+actualHomePageTitle +" "+ "Expected title was "+expectedHomePageTitle);

        }

        [TestInitialize]
        public void TestInitilizaMethod()
        {
            driver = new ChromeDriver();
            Console.WriteLine("Opening Browser");

            webDriverUtilities = new IWebDriverUtilities();
            Console.WriteLine( "Initilizing webDriverUtilities" );

            loginPageElements = new LoginPageElements(driver);
            Console.WriteLine("Initilizing loginPageElements");
        }
        [TestCleanup]
        public void TestCleanUpMethod()
        {
            Console.WriteLine("validating the title ");
            Console.WriteLine("actualHomePageTitle is " + actualHomePageTitle);
            Console.WriteLine("expectedHomePageTitle is " + expectedHomePageTitle);

            driver.Close();
            Console.WriteLine("Closing the Browser");
            driver.Dispose();

        }
    }
}
