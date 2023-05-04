using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Thread.Sleep(5000);
        }

        [TestMethod]
        [TestCategory("Parallel")]
        public void TestMethod2()
        {
            Console.WriteLine("t2");
            Thread.Sleep(8000);
        }

        [TestMethod]
        [TestCategory("Parallel")]
        public void TestMethod3()
        {
            Console.WriteLine("t3");
            Thread.Sleep(10000);
        }
    }
}
