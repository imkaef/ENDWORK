using System;
using System.Drawing;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace WindowsFormsApp1 {
    public partial class MainWindow : Form
    {
        Form2 f2 = new Form2();
        Regex regex = new Regex(@"[-]{0,1}[\d]{1,3}[.][\d]{2}[/][-]{0,1}[\d]{1,3}[.][\d]{2}[/][-]{0,1}[\d]{1,3}[.][\d]{2}[/][-]{0,1}[\d]{1,3}[.][\d]{2}");
        T Tc = new T();
        TimeSpan ts = new TimeSpan(0, 0, 0, 1, 0);

        public MainWindow() => InitializeComponent();

        double d1 = global::Temperature.Properties.Settings.Default.D1;
        double d2 = global::Temperature.Properties.Settings.Default.D2;
        double d3 = global::Temperature.Properties.Settings.Default.D3;
        double d4 = global::Temperature.Properties.Settings.Default.D4;
        double time = 0;
        string[] ports;
        string SerialPortData = " ";
        string[] SensorsTmperature = new string[4];
        bool flag = true;
        System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();

        public void ChartFill() { 
            TemperatureChart.Series.Clear();
            TemperatureChart.Titles.Add("График температуры");

            DeltaChart.Series.Clear();
            DeltaChart.Titles.Add("График изменения температуры");

            Series series1 = TemperatureChart.Series.Add("Датчик №1\r\n");
            Series series2 = TemperatureChart.Series.Add("Датчик №2\r\n");
            Series series3 = TemperatureChart.Series.Add("Датчик №3\r\n");
            Series series4 = TemperatureChart.Series.Add("Датчик №4\r\n");

            Series delta1 = DeltaChart.Series.Add("Разница №2\r\n");
            Series delta2 = DeltaChart.Series.Add("Разница №3\r\n");
            Series delta3 = DeltaChart.Series.Add("Разница №4\r\n");

            series1.ChartType = SeriesChartType.FastLine;
            series2.ChartType = SeriesChartType.FastLine;
            series3.ChartType = SeriesChartType.FastLine;
            series4.ChartType = SeriesChartType.FastLine;

            delta1.ChartType = SeriesChartType.FastLine;
            delta2.ChartType = SeriesChartType.FastLine;
            delta3.ChartType = SeriesChartType.FastLine;

            TemperatureChart.Series[0].Color = Color.Green;
            TemperatureChart.Series[1].Color = Color.Blue;
            TemperatureChart.Series[2].Color = Color.Purple;
            TemperatureChart.Series[3].Color = Color.Red;

            DeltaChart.Series[0].Color = Color.Green;
            DeltaChart.Series[1].Color = Color.Blue;
            DeltaChart.Series[2].Color = Color.Red;

           // TemperatureChart.ChartAreas[0].AxisX.ScaleView.Size = 10;                       //<---
            
              TemperatureChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
              TemperatureChart.ChartAreas[0].CursorX.AutoScroll = false;

                TemperatureChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                 TemperatureChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            TemperatureChart.ChartAreas[0].AxisX.Minimum = 0;
            DeltaChart.ChartAreas[0].AxisX.Minimum = 0;
        }
        
        private void MainWindow_Load(object sender, EventArgs e) {
            ports = SerialPort.GetPortNames();
            ComPortMenu.Items.Clear();
            ComPortMenu.Items.AddRange(ports);
            try { ComPortMenu.SelectedIndex = 0; }
            catch { }
            ChartFill();
            ChekBoxes2.Location = new Point(Screen.PrimaryScreen.Bounds.Width-180, Screen.PrimaryScreen.Bounds.Height-340);
            ChekBoxes1.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 180, Screen.PrimaryScreen.Bounds.Height - 790);

            tableLayoutPanel6.Width =  Screen.PrimaryScreen.Bounds.Width;
            tableLayoutPanel6.Height = Screen.PrimaryScreen.Bounds.Height;

        }

        private void ConnectDisconnect_Click(object sender, EventArgs e) {
            if (ConnectDisconnect.Text == "Соединение")
                try {
                    serialPort1.PortName = ComPortMenu.Text;
                    serialPort1.Open();
                    System.Threading.Thread.Sleep(1000);
                    ConnectDisconnect.Text = "Разъединить";
                    StartEnd.Enabled = true;
                    global::Temperature.Properties.Settings.Default.Reload();
                    double d1 = global::Temperature.Properties.Settings.Default.D1;
                    double d2 = global::Temperature.Properties.Settings.Default.D2;
                    double d3 = global::Temperature.Properties.Settings.Default.D3;
                    double d4 = global::Temperature.Properties.Settings.Default.D4;
                }
                catch { MessageBox.Show("Ошибка подключения к устройству"); }
            else {
                StartEnd.Text = "Начать";
                ConnectDisconnect.Text = "Соединение";
                StartEnd.Enabled = false;
                serialPort1.Close();
                time = 0;
                TemperatureChart.Series[0].Points.Clear();
                TemperatureChart.Series[1].Points.Clear();
                TemperatureChart.Series[2].Points.Clear();
                TemperatureChart.Series[3].Points.Clear();
                DeltaChart.Series[0].Points.Clear();
                DeltaChart.Series[1].Points.Clear();
                DeltaChart.Series[2].Points.Clear();
                Data.Rows.Clear();
                 }
        }

        private void StartEnd_Click(object sender, EventArgs e) {
            if (StartEnd.Text == "Начать") { StartEnd.Text = "Остановить";}
            else if (StartEnd.Text == "Остановить") { StartEnd.Text = "Начать";}
        }
        
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            try { SerialPortData = serialPort1.ReadLine().Replace("\r", "");}
            catch {}
            SensorsTmperature=SerialPortData.Split('/');
            global::Temperature.Properties.Settings.Default.Reload();
            if (InvokeRequired) {
                try {
                    Invoke((MethodInvoker)delegate {
                        if (regex.IsMatch(SerialPortData) && StartEnd.Text == "Остановить") {
                            Data.Rows.Add(time, Convert.ToDouble(SensorsTmperature[0].Replace('.', ',')) + global::Temperature.Properties.Settings.Default.D1, Convert.ToDouble(SensorsTmperature[1].Replace('.', ',')) + global::Temperature.Properties.Settings.Default.D2, Convert.ToDouble(SensorsTmperature[2].Replace('.', ',')) + global::Temperature.Properties.Settings.Default.D3, Convert.ToDouble(SensorsTmperature[3].Replace('.', ',')) + global::Temperature.Properties.Settings.Default.D4);
                        }});
                } catch {}}}
        
        private void Data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {

            if (flag) { myStopwatch.Start(); flag = false; }
            else {
                if (myStopwatch.Elapsed < ts) System.Threading.Thread.Sleep(ts - myStopwatch.Elapsed);
                myStopwatch.Stop();
                myStopwatch.Reset();
                flag = true;
            }
            SensorsTmperature[0] = SensorsTmperature[0].Replace('.', ',');
            SensorsTmperature[1] = SensorsTmperature[1].Replace('.', ',');
            SensorsTmperature[2] = SensorsTmperature[2].Replace('.', ',');
            SensorsTmperature[3] = SensorsTmperature[3].Replace('.', ',');

            Tc.output(SensorsTmperature, time, TemperatureChart);
            Tc.Td(SensorsTmperature,time, DeltaChart);
            time += 1;
            
            if (Data.RowCount > 20 && AutoScrollll.Checked) Data.FirstDisplayedScrollingRowIndex = Data.RowCount - 20;
            if (time % 1000 == 0) ZoomBar.Maximum += 1000;  ;
        }
        
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            serialPort1.Close();
            System.Threading.Thread.Sleep(999);
        }
        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
            StartEnd.Text = "Начать";
            SaveFileDialog sf = new SaveFileDialog();

            sf.InitialDirectory = @"";
            sf.RestoreDirectory = true;
            sf.FileName = "Data";
            sf.DefaultExt = "xlsx";
            sf.Filter = "xlsx files  (*.xlsx)|*.xlsx";

            if (sf.ShowDialog() == DialogResult.OK) {
                try { Tc.savex(sf.FileName, Data); }
                catch { }
            }
        }

        private void калибровкаToolStripMenuItem_Click(object sender, EventArgs e) => f2.ShowDialog();

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) TemperatureChart.Series[0].Color = Color.Green;
            else TemperatureChart.Series[0].Color = Color.Transparent;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) TemperatureChart.Series[1].Color = Color.Blue;
            else TemperatureChart.Series[1].Color = Color.Transparent;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            if (checkBox4.Checked) TemperatureChart.Series[2].Color = Color.Purple;
            else TemperatureChart.Series[2].Color = Color.Transparent;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            if (checkBox5.Checked) DeltaChart.Series[0].Color = Color.Green;
            else DeltaChart.Series[0].Color = Color.Transparent;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e) {
            if (checkBox6.Checked) DeltaChart.Series[1].Color = Color.Blue;
            else DeltaChart.Series[1].Color = Color.Transparent;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e) {
            if (checkBox7.Checked) TemperatureChart.Series[3].Color = Color.Red;
            else TemperatureChart.Series[3].Color = Color.Transparent;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) DeltaChart.Series[2].Color = Color.Red;
            else DeltaChart.Series[2].Color = Color.Transparent;
        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e) {
            try { System.Diagnostics.Process.Start(@"Инструкция для пользователя.docx"); }
            catch { MessageBox.Show("Файл описания програ найден"); }
        }

        private void ZoomBar_Scroll_1(object sender, ScrollEventArgs e) {
            TemperatureChart.ChartAreas[0].AxisX.ScaleView.Size = (time / 100) * ZoomBar.Value + 50;

        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e) {
            MessageBox.Show("   ");
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e) {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) {

        }
    }
}