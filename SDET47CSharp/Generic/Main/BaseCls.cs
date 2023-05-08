using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET47CSharp.Generic.Main
{
    [TestClass]
    public class BaseCls
    {
        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public ExtentTest extentTest;
        public string screenShotPath;
        public static BaseCls instance=new BaseCls();
        public static ExtentHtmlReporter extentHtmlReporter;
        public static string testResultPath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\Generic\\Utilities\\Reports\\";
        public static TestContext testContext;

        public TestContext TestContext 
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [AssemblyInitialize]
        public static void AssemblyIniTializeMethod(TestContext testContext)
        {
            extentReports = new ExtentReports();
           // instance.ExtendReportInitilize();
            Console.WriteLine("codeIni");
            extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AttachReporter(extentHtmlReporter);
            //input aabbccddaabb
            //op a2b2c2d2a2b2
        }

        public void ExtendReportInitilize()
        {
            // MessageBox.Show("Asem INI");

        }

        public void ExtendReportCleanup()
        {

        }

        [AssemblyCleanup]
        public static void AssemblyCleanUpMethod()
        {
            //instance.ExtendReportCleanup();
            extentReports.Flush();
            Console.WriteLine("cleanup");
            extentHtmlReporter.Stop();
        }
    }
}
