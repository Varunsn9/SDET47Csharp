using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDET47CSharp.MsTest
{
    [TestClass]
    public class DynamicDataDataDriven
    {
         public static IEnumerable<object[]> AdditionData  
        {
            get
            {
                return new[]
                {
                    new object[] { 1, 1, 2 },
                    new object[] { 2, 2, 4 },
                    new object[] { 3, 3, 6 },
                    new object[] { 3, 2, 5 },
                    new object[] { 2, 6, 8 },
                };
            }
        }

        [TestMethod]
        [TestCategory("DynamicData"),TestCategory("DataDriven")]
        [DynamicData(nameof(AdditionData),DynamicDataSourceType.Property)]
        public void UsingPropertyDynamicDataTestMethod(int a,int b,int c)
        {
            int adding = a + b;
            bool result=false;
            if (adding == c)
            {
                result = true;
            }
            Assert.IsTrue(result,"Result is not matching");
            MessageBox.Show(" "+c);
        }


        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(numberData),DynamicDataSourceType.Method)]
        public void UsingMethodDynamicDataTestMethod(int a, int b, int c)
        {
            int adding = a + b;
            bool result = false;
            if (adding == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "Result is not matching");
          //  MessageBox.Show(" " + c);
        }

        public static IEnumerable<object[]> AdditionDataMethod()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, 3, 6 };
            yield return new object[] { 3, 2, 5 };
            yield return new object[] { 2, 6, 8 };   
        }

        public static IEnumerable<object[]> numberData()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, 3, 6 };
            yield return new object[] { 3, 2, 5 };
            yield return new object[] { 2, 6, 8 };

        }

    }
}
