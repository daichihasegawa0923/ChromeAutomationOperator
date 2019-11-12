using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ParseExcelToDataTable
{
    public class ParseExcel
    {
        public DataTable GetDataTableFromExcel(string workBookPath, string sheetName, bool isTopLineIsKind)
        {
            var workBook = new XLWorkbook(workBookPath);
            var sheet = workBook.Worksheet(sheetName);
            var lastCell = sheet.LastCellUsed();
            var width = lastCell.Address.ColumnNumber;
            var height = lastCell.Address.RowNumber;
            var dataTable = new DataTable();
            return dataTable;
        }
    }
}
