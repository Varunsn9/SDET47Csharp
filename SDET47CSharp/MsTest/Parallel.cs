using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Threading;

namespace SDET47CSharp.MsTest
{
    [TestClass]
    public class Parallel //to execute in parallel mode in vstest.console.exe packagename.dll /parallel  
    {
        [TestMethod]
        [TestCategory("Parallel")]
        public void TestMethod1()
        {
            Console.WriteLine( "t1" );
            Thread.Sleep(1000);
            //Logger.LogMessage("logging a message in passed script");
        }

        [TestMethod]
        [TestCategory("Parallel")]
        public void TestMethod2()
        {
            Console.WriteLine("t2");
            Thread.Sleep(1000);
            Assert.Fail("Failing using Assert.Fail()");
           // Logger.LogMessage("logging a message in Failed Script");
        }

        [TestMethod]
        [TestCategory("Parallel")]
        public void TestMethod3()
        {
            Console.WriteLine("t3");
            Thread.Sleep(1000);
            //Logger.LogMessage("logging a message in passed script");
        }
    }
}
