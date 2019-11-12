using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseExcelToDataTable;

namespace ChromeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Url = "https://google.com";
            new ParseExcel().GetDataTableFromExcel
                (@"C:\Users\Daichi Hasegawa\source\repos\ChromeAutomationOperator\Script.xlsx","Sample",true);
        }
    }
}
