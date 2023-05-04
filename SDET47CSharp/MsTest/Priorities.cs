using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace SDET47CSharp.MsTest
{
    [TestClass]
    public class Priorities 
    {
        [TestMethod]
        [TestCategory("Priorities")]
        [Priority(3)]
        public void TestMethod3()
        {
            MessageBox.Show("P3");
        }

        [TestMethod]
        [TestCategory("Priorities")]
        [Priority(0)]
        public void TestMethod1()
        {
            MessageBox.Show("P0");
        }

        

        
    }
}
