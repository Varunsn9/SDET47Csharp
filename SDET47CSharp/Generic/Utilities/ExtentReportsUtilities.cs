using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;
using SDET47CSharp.Generic.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET47CSharp.Generic.Utilities
{
    [TestClass]
    public class ExtentReportsUtilities : BaseCls
    {

        [ClassInitialize]
        public static void ClassInitilize(TestContext testContext)
        {
            driver = new ChromeDriver();
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Close();
            driver.Dispose();

        }

        [TestInitialize]
        public void ExtentReportsMethod()
        {

           
            
           // extentTest = extentReports.CreateTest("TestInilize");

            //driver = new ChromeDriver();
            extentTest = extentReports.CreateTest(TestContext.TestName+" "+TestContext.DataRow);
        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void Facebook()
        {
            //extentTest = extentReports.CreateTest("Facebook");
            
            driver.Navigate().GoToUrl("https://www.facebook.com");
         
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot=takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\ScreenShot\\"+TestContext.TestName+".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Info, "facebook taking a screenshot");
            
            bool condition=false;
            if (condition == true)
            {
                Assert.IsTrue(true);
                extentTest.Pass("TestPassed");
            }
            else
            {
                try
                {
                    Assert.IsTrue(false);
                }
                catch(Exception ex)
                {

                    extentTest.Fail("TestFailed");
                }
            }
        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void Google()
        {
            //extentTest = extentReports.CreateTest("Google");
            driver.Navigate().GoToUrl("https://www.google.com");
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\ScreenShot\\"+TestContext.TestName+".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Warning, "Its is a status Waring");
            extentTest.Warning("ExtentTestWarning Method");
            Assert.IsTrue(true);
            extentTest.Pass("TestPassed");
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("Facebook", "https://www.facebook.com")]
        [DataRow("Google", "https://www.google.com")]
        [DataRow("Vtiger", "http://www.localhost:8888")]
        [TestCategory("ExtentHtmlReporter")]
        public void DataDriven(string website,string url)
        {
            //extentTest = extentReports.CreateTest("Facebook");

            driver.Navigate().GoToUrl(url);

            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\ScreenShot\\" + TestContext.TestName +" "+ website +".png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Info, TestContext.TestName+" "+website+" taking a screenshot");

            bool condition = false;
            if (condition == true)
            {
                Assert.IsTrue(true);
                extentTest.Pass("TestPassed");
            }
            else
            {
                try
                {
                    Assert.IsTrue(false);
                }
                catch (Exception ex)
                {

                    extentTest.Fail("TestFailed");
                }
            }
        }

        [TestCleanup]
        public void ExtentReportTearDown()
        {

            extentTest.AddScreenCaptureFromPath(screenShotPath);
        }
    }
}