using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET47CSharp.Generic.Utilities
{
    [TestClass]
    public class ExcelUtilities
    {
        /// <summary>
        /// this is method to get data from excel sheet
        /// </summary>
        /// <param name="FilePath">path of the excel file in a string type</param>
        /// <param name="Sheetname">name of the sheet inside the excel file in a string type</param>
        /// <param name="Row">row of the sheet in int type</param>
        /// <param name="Cell">column of the sheet in the int type</param>
        /// <returns></returns>
        public String GetExcelData(String FilePath, String Sheetname, int Row, int Cell)
        {

            Spreadsheet spreadsheet = new Spreadsheet();
            //creating an instance
            spreadsheet.LoadFromFile(FilePath);
            //loading the path to the spreadsheet
            String data = spreadsheet.Workbook.Worksheets.ByName(Sheetname).Cell(Row, Cell).ToString();
            //getting the data from the excel sheet and storing in string data
            spreadsheet.Dispose();
            return data;
            //returning data
        }

        [TestMethod,TestCategory("ExcelData")]
        
        public void ExcelUtilitiesTest()
        {
            ExcelUtilities excelUtilities=new ExcelUtilities();
            string filePath = "C:\\Users\\VARUN SN\\source\\repos\\SDET47CSharp\\SDET47CSharp\\TestData\\ExcelData\\Data.xlsx";
            string sheetName = "Sheet1";
            string data= excelUtilities.GetExcelData(filePath,sheetName,0,0);
            Console.WriteLine( data );
        }
    }
}
