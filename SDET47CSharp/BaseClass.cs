using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SDET47CSharp
{

    [TestClass]
    public class BaseClass
    {
        

        [TestInitialize]
        [Priority(0)]
        public void TestInitialize()
        {
            MessageBox.Show("Test INI p0");
        }
        [TestCleanup]
        [Priority(0)]
        public void TestCleanUp()
        {
            MessageBox.Show("Test Cup p0");
        }
        [TestInitialize]
        [Priority(1)]

        public void TestInitialize1()
        {
            MessageBox.Show("Test INI p1");
        }
        [TestCleanup]
        [Priority(1)]
        public void TestCleanUp1()
        {
            MessageBox.Show("Test Cup p1");
        }
        /*[TestInitialize]
        [Priority(2)]

        public void TestInitialize2()
        {
            MessageBox.Show("Test INI p2");
        }
        [TestCleanup]
        [Priority(2)]
        public void TestCleanUp2()
        {
            MessageBox.Show("Test Cup p2");
        }
*/

    }
}
