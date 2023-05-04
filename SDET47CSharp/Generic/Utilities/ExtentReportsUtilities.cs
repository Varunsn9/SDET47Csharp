using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
       

        [TestInitialize]
        public void ExtentReportsMethod()
        {

           
            extentReports.AttachReporter(extentHtmlReporter);
           // extentTest = extentReports.CreateTest("TestInilize");

            driver = new ChromeDriver();

        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void facebook()
        {
            extentTest = extentReports.CreateTest("Facebook");
            driver.Navigate().GoToUrl("https://www.facebook.com");
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot=takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\ScreenShot\\Facebook.png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

            extentTest.Log(Status.Info, "facebook");
            Assert.IsTrue(true);
              extentTest.Pass("TestPassed");
        }

        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        public void google()
        {
           extentTest = extentReports.CreateTest("Google");
            driver.Navigate().GoToUrl("https://www.google.com");
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\ScreenShot\\Google.png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

         extentTest.Log(Status.Pass, "Google");
            Assert.IsTrue(true);
          extentTest.Pass("TestPassed");
        }

        [TestCleanup]
        public void ExtentReportTearDown()
        {

            driver.Close();
            driver.Dispose();
            //extentReports.Flush();
            extentTest.AddScreenCaptureFromPath(testResultPath);
        }
    }
}