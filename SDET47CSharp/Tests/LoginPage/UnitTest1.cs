using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDET47CSharp.Generic.Main;
using System;

namespace SDET47CSharp.Tests.LoginPage
{
    [TestClass]
    public class UnitTest1 : BaseCls
    {
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
