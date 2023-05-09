using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET47CSharp.Generic.Utilities
{
    public struct PathConstants
    {
        private const string excelPath= "path of the excel";
        private const string csvPath = "path of the csv";
        
        public string Paths(Path file)
        {
            string path = null;
            if (file.Equals(Path.excelPath))
            {
                path= excelPath;
            }
            else if(file.Equals(Path.csvPath))
            {
                path= csvPath;
            }
            return path;
        }

    }
    public enum Path
    {
        excelPath,csvPath

    }
    

}
