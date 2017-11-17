using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using ExcelApp = Microsoft.Office.Interop.Excel.Application;

namespace EasySystemClassification
{

    class ExcelOperator
    {
        private string _mFileName;

        // Excel对象
        private ExcelApp _mApp;
        private Workbooks _mBooks;
        private Workbook _mBook;
        public Sheets Sheets;

        public void CreateExcel()
        {
            _mApp = new ExcelApp();
            _mBooks = _mApp.Workbooks;
            _mBook = _mBooks.Add(true);
            Sheets = _mBook.Worksheets;
        }

        public void OpenExcel(string fileName)
        {
            _mApp = new ExcelApp();
            _mBooks = _mApp.Workbooks;
            _mBook = _mBooks.Add(fileName);
            Sheets = _mBook.Worksheets;
            _mFileName = fileName;
        }

        public Worksheet GetSheet(string sheetName)
        {
            var sheet = (Worksheet)_mBook.Worksheets[sheetName];
            return sheet;
        }

        public Worksheet AddSheet(string sheetName)
        {
            var sheet = (Worksheet)_mBook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            sheet.Name = sheetName;
            return sheet;
        }

        public void DelSheet(string sheetName)
        {
            ((Worksheet)_mBook.Worksheets[sheetName]).Delete();
        }

        public Worksheet ReNameSheet(string oldSheetName, string newSheetName)
        {
            var sheet = (Worksheet)_mBook.Worksheets[oldSheetName];
            sheet.Name = newSheetName;
            return sheet;
        }

        public Worksheet ReNameSheet(Worksheet oldSheet, string newSheetName)
        {
            oldSheet.Name = newSheetName;
            return oldSheet;
        }

        public List<string> GetSheetList()
        {
            return (from object t in Sheets select ((Worksheet) t).Name).ToList();
        }

        public long MaxUsedRowCount(string sheetName)
        {
            return GetSheet(sheetName).UsedRange.Rows.Count;
        }

        public long MaxUsedColumnCount(string sheetName)
        {
            return GetSheet(sheetName).UsedRange.Columns.Count;
        }

        public void SetCellValue(Worksheet sheet, long x, long y, object value)
        {
            sheet.Cells[x, y] = value;
        }
        public void SetCellValue(string sheetName, long x, long y, object value)
        {
            GetSheet(sheetName).Cells[x, y] = value;
        }

        public string GetCellValue(Worksheet sheet, long x, long y)
        {
            return ((Range)sheet.Cells[x, y]).Text;
        }

        public string GetCellValue(string sheetName, long x, long y)
        {
            return ((Range)GetSheet(sheetName).Cells[x, y]).Text;
        }

        public void UniteCells(Worksheet sheet, long x1, long y1, long x2, long y2)
        {
            sheet.Range[sheet.Cells[x1, y1], sheet.Cells[x2, y2]].Merge(Type.Missing);
        }

        public void UniteCells(string sheet, long x1, long y1, long x2, long y2)
        {
            GetSheet(sheet).Range[GetSheet(sheet).Cells[x1, y1], GetSheet(sheet).Cells[x2, y2]].Merge(Type.Missing);
        }

        public bool Save()
        {
            if (_mFileName == "")
            {
                return false;
            }
            try
            {
                _mBook.Save();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
        public bool SaveAs(object fileName)
            //文档另存为
        {
            try
            {
                _mBook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                    XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                return true;

            }
            catch (Exception)
            {
                return false;

            }
        }
        public void Close()
            //关闭一个Microsoft.Office.Interop.Excel对象，销毁对象
        {
            //wb.Save();
            _mBook.Close(Type.Missing, Type.Missing, Type.Missing);
            _mBooks.Close();
            _mApp.Quit();
            _mBook = null;
            _mBooks = null;
            _mApp = null;
            GC.Collect();
        }
    }
}
