using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using SDET47CSharp.Generic.Main;
using System;

namespace SDET47CSharp.Tests.LoginPage
{
    [TestClass]
    public class UnitTest1 : BaseCls
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine(TestContext.TestName);
        }
        [TestCleanup] public void TestCleanup() 
        {  
            Console.WriteLine(TestContext.TestName);
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testcontext)
        {
            Console.WriteLine("CI");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("CC");
        }

        [TestMethod]
        [TestCategory("TCX")]
        public void TestMethod1()
        {
            Console.WriteLine(TestContext.Properties["Browser"]);
            Console.WriteLine(TestContext.TestName);
            Console.WriteLine(TestContext.TestResultsDirectory);
            Console.WriteLine(TestContext.CurrentTestOutcome);
        }
    }
}
