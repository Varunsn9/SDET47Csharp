using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SDET47CSharp.MsTest
{
    [TestClass]
    public class DataRowDataDriven
    {

        [DataTestMethod]
        [DataRow("Lakshmi", 47)]//Url and validate Expected title
        [DataRow("Rajeev", 47)]
        [DataRow("Abhishek", 47)]
        [DataRow("Raja", 47)]


        [TestMethod]
        [TestCategory("DataDriven")]
        [Priority(1)]
        public void DataRowAndDataDriven(String name, int batch)
        {

            Console.WriteLine(name + " " + batch);
            MessageBox.Show(name);
            try
            {
              Assert.IsTrue(name.Equals("Lakshmi"));
            }
            catch(Exception e)
            {
                Console.WriteLine( name + " is not matching with Lakshmi");
                Console.WriteLine(e.StackTrace ); 
            }
            finally
            {
                Assert.IsTrue(name.Equals("Lakshmi"));
            } 
        }

        
        [TestMethod,TestCategory("DataTest")]
        public void DataTesting(String name, int batch)
        {
            Console.WriteLine( name + " " + batch );
            IWebDriver driver = new ChromeDriver();
            
        }
    }
}
