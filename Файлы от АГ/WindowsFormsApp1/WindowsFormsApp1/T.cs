using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1 {
    class T {
        bool f = false;

        public void output (string[] T, double time, Chart chart1) {
            chart1.Series[0].Points.AddXY(time, Convert.ToDouble(T[0]) + Temperature.Properties.Settings.Default.D1);
            chart1.Series[1].Points.AddXY(time, Convert.ToDouble(T[1]) + Temperature.Properties.Settings.Default.D2);
            chart1.Series[2].Points.AddXY(time, Convert.ToDouble(T[2]) + Temperature.Properties.Settings.Default.D3);
            chart1.Series[3].Points.AddXY(time, Convert.ToDouble(T[3]) + Temperature.Properties.Settings.Default.D4);
        }
        
        public void savex(string way, DataGridView dataGrid) {
            Ex ex = new Ex();
            ex.CreateFile();
            ex.GridWrite(dataGrid);
            ex.SaveAs(way);
            ex.Close();
        }

        public void Td (string[] T, double time ,Chart chart2) {
            if (f) {
                chart2.Series[0].Points.AddXY(time, (Convert.ToDouble(T[0]) + Temperature.Properties.Settings.Default.D1) - (Convert.ToDouble(T[1]) + Temperature.Properties.Settings.Default.D1));
                chart2.Series[1].Points.AddXY(time, (Convert.ToDouble(T[0]) + Temperature.Properties.Settings.Default.D1) - (Convert.ToDouble(T[2]) + Temperature.Properties.Settings.Default.D2));
                chart2.Series[2].Points.AddXY(time, (Convert.ToDouble(T[0]) + Temperature.Properties.Settings.Default.D1) - (Convert.ToDouble(T[3]) + Temperature.Properties.Settings.Default.D3));
            }
            f = true;
        }
    }
}
