using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_ReadExcel.Models
{
    public static class ExcelPackageExtension
    {
        public static DataTable ToDataTable(this ExcelPackage package)
        {
            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();
            DataTable dt = new DataTable();

            foreach(var firstRowCell in workSheet.Cells[1,1,1,workSheet.Dimension.End.Column])
            {
                dt.Columns.Add(firstRowCell.Text);
            }

            for(var rownumber =2; rownumber<= workSheet.Dimension.End.Row; rownumber++)
            {
                var row = workSheet.Cells[rownumber, 1, rownumber, workSheet.Dimension.End.Column];
                var newRow = dt.NewRow();

                foreach(var cell in row)
                {
                    newRow[cell.Start.Column - 1] = cell.Text;
                }

                dt.Rows.Add(newRow);
            }
            return dt;
        }
    }
}