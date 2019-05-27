using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1 {

    class Ex {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Ex() { }

        public Ex(string path, int sheet) {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public string Read(int i, int j) {
            double num;
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null && !(double.TryParse(ws.Cells[i, j].Value2, out num)))
                return Convert.ToString(ws.Cells[i, j].Value2);
            else return " ";
        } 
        
        public void Write (int i, int j, string s) {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        } 
        
        public void GridWrite(DataGridView dataGrid)   {
            ws.Rows[1].Columns[1] = "t";
            ws.Rows[1].Columns[2] = "Датчик 1";
            ws.Rows[1].Columns[3] = "Датчик 2";
            ws.Rows[1].Columns[4] = "Датчик 3";
            ws.Rows[1].Columns[5] = "Датчик 4";

            for (int i = 1; i < dataGrid.RowCount + 1; i++) {
                for (int j = 1; j < dataGrid.ColumnCount + 1; j++) {
                    ws.Rows[i + 1].Columns[j] = dataGrid.Rows[i - 1].Cells[j - 1].Value;
                }
            }
        }

        public void CreateFile() {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }

        public void CreateSheet() {
            Worksheet tempsheet = wb.Worksheets.Add(After: ws);
        }
        
        public void Save() => wb.Save();

        public void SaveAs(string path) => wb.SaveAs(path);

        public void Close() => wb.Close();

    }
}
