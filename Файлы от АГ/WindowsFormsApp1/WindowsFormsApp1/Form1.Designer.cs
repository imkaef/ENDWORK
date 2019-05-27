namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ComPortMenu = new System.Windows.Forms.ComboBox();
            this.ConnectDisconnect = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoScrollll = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калибровкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartEnd = new System.Windows.Forms.Button();
            this.TemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeltaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ZoomBar = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ChekBoxes1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.ChekBoxes2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.ChekBoxes1.SuspendLayout();
            this.ChekBoxes2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortMenu
            // 
            this.ComPortMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComPortMenu.FormattingEnabled = true;
            this.ComPortMenu.Location = new System.Drawing.Point(3, 2);
            this.ComPortMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComPortMenu.Name = "ComPortMenu";
            this.ComPortMenu.Size = new System.Drawing.Size(341, 24);
            this.ComPortMenu.TabIndex = 0;
            // 
            // ConnectDisconnect
            // 
            this.ConnectDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectDisconnect.Location = new System.Drawing.Point(3, 2);
            this.ConnectDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectDisconnect.Name = "ConnectDisconnect";
            this.ConnectDisconnect.Size = new System.Drawing.Size(164, 30);
            this.ConnectDisconnect.TabIndex = 1;
            this.ConnectDisconnect.Text = "Соединение";
            this.ConnectDisconnect.UseVisualStyleBackColor = true;
            this.ConnectDisconnect.Click += new System.EventHandler(this.ConnectDisconnect_Click);
            // 
            // Data
            // 
            this.Data.AllowUserToResizeRows = false;
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.D1,
            this.D2,
            this.D3,
            this.D4});
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(3, 103);
            this.Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 24;
            this.Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Data.Size = new System.Drawing.Size(341, 840);
            this.Data.TabIndex = 9;
            this.Data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Data_RowsAdded);
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            // 
            // D1
            // 
            this.D1.HeaderText = "Д1";
            this.D1.Name = "D1";
            // 
            // D2
            // 
            this.D2.HeaderText = "Д2";
            this.D2.Name = "D2";
            // 
            // D3
            // 
            this.D3.HeaderText = "Д3";
            this.D3.Name = "D3";
            // 
            // D4
            // 
            this.D4.HeaderText = "Д4";
            this.D4.Name = "D4";
            // 
            // AutoScrollll
            // 
            this.AutoScrollll.AutoSize = true;
            this.AutoScrollll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoScrollll.Location = new System.Drawing.Point(3, 73);
            this.AutoScrollll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoScrollll.Name = "AutoScrollll";
            this.AutoScrollll.Size = new System.Drawing.Size(341, 26);
            this.AutoScrollll.TabIndex = 10;
            this.AutoScrollll.Text = "Автопрокрутка";
            this.AutoScrollll.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM24";
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.калибровкаToolStripMenuItem,
            this.оПрограмеToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1924, 28);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // калибровкаToolStripMenuItem
            // 
            this.калибровкаToolStripMenuItem.Name = "калибровкаToolStripMenuItem";
            this.калибровкаToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.калибровкаToolStripMenuItem.Text = "Калибровка";
            this.калибровкаToolStripMenuItem.Click += new System.EventHandler(this.калибровкаToolStripMenuItem_Click);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограмеToolStripMenuItem.Text = "О программе";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.оПрограмеToolStripMenuItem_Click);
            // 
            // StartEnd
            // 
            this.StartEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartEnd.Enabled = false;
            this.StartEnd.Location = new System.Drawing.Point(173, 2);
            this.StartEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartEnd.Name = "StartEnd";
            this.StartEnd.Size = new System.Drawing.Size(165, 30);
            this.StartEnd.TabIndex = 2;
            this.StartEnd.Text = "Начать";
            this.StartEnd.UseVisualStyleBackColor = true;
            this.StartEnd.Click += new System.EventHandler(this.StartEnd_Click);
            // 
            // TemperatureChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TemperatureChart.ChartAreas.Add(chartArea1);
            this.TemperatureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.TemperatureChart.Legends.Add(legend1);
            this.TemperatureChart.Location = new System.Drawing.Point(3, 2);
            this.TemperatureChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TemperatureChart.Name = "TemperatureChart";
            this.TemperatureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TemperatureChart.Series.Add(series1);
            this.TemperatureChart.Size = new System.Drawing.Size(1537, 560);
            this.TemperatureChart.TabIndex = 5;
            this.TemperatureChart.Text = "chart1";
            // 
            // DeltaChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DeltaChart.ChartAreas.Add(chartArea2);
            this.DeltaChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.DeltaChart.Legends.Add(legend2);
            this.DeltaChart.Location = new System.Drawing.Point(3, 566);
            this.DeltaChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeltaChart.Name = "DeltaChart";
            this.DeltaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DeltaChart.Series.Add(series2);
            this.DeltaChart.Size = new System.Drawing.Size(1537, 377);
            this.DeltaChart.TabIndex = 8;
            this.DeltaChart.Text = "chart3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AutoScrollll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Data, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComPortMenu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 844F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 945);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.StartEnd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ConnectDisconnect, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 34);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.ZoomBar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TemperatureChart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DeltaChart, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(356, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.76563F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.23438F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1565, 945);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // ZoomBar
            // 
            this.ZoomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomBar.Location = new System.Drawing.Point(1543, 0);
            this.ZoomBar.Minimum = 1;
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Size = new System.Drawing.Size(22, 564);
            this.ZoomBar.TabIndex = 23;
            this.ZoomBar.Value = 100;
            this.ZoomBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZoomBar_Scroll_1);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1924, 1062);
            this.tableLayoutPanel6.TabIndex = 24;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(3, 2);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(3, 37);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(3, 66);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(3, 34);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(3, 2);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChekBoxes1
            // 
            this.ChekBoxes1.ColumnCount = 1;
            this.ChekBoxes1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChekBoxes1.Controls.Add(this.checkBox2, 0, 0);
            this.ChekBoxes1.Controls.Add(this.checkBox3, 0, 1);
            this.ChekBoxes1.Controls.Add(this.checkBox4, 0, 2);
            this.ChekBoxes1.Controls.Add(this.checkBox7, 0, 3);
            this.ChekBoxes1.Location = new System.Drawing.Point(533, 960);
            this.ChekBoxes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChekBoxes1.Name = "ChekBoxes1";
            this.ChekBoxes1.RowCount = 4;
            this.ChekBoxes1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChekBoxes1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChekBoxes1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChekBoxes1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ChekBoxes1.Size = new System.Drawing.Size(27, 130);
            this.ChekBoxes1.TabIndex = 26;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(3, 98);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(18, 17);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // ChekBoxes2
            // 
            this.ChekBoxes2.ColumnCount = 1;
            this.ChekBoxes2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ChekBoxes2.Controls.Add(this.checkBox5, 0, 0);
            this.ChekBoxes2.Controls.Add(this.checkBox6, 0, 1);
            this.ChekBoxes2.Controls.Add(this.checkBox1, 0, 2);
            this.ChekBoxes2.Location = new System.Drawing.Point(564, 978);
            this.ChekBoxes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChekBoxes2.Name = "ChekBoxes2";
            this.ChekBoxes2.RowCount = 3;
            this.ChekBoxes2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.ChekBoxes2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.ChekBoxes2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.ChekBoxes2.Size = new System.Drawing.Size(25, 95);
            this.ChekBoxes2.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 69);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.ChekBoxes1);
            this.Controls.Add(this.ChekBoxes2);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ChekBoxes1.ResumeLayout(false);
            this.ChekBoxes1.PerformLayout();
            this.ChekBoxes2.ResumeLayout(false);
            this.ChekBoxes2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortMenu;
        private System.Windows.Forms.Button ConnectDisconnect;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.CheckBox AutoScrollll;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калибровкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.Button StartEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart TemperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DeltaChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.VScrollBar ZoomBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TableLayoutPanel ChekBoxes1;
        private System.Windows.Forms.TableLayoutPanel ChekBoxes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

