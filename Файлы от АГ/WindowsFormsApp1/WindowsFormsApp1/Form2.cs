using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form2 : Form {

        public Form2() {
            InitializeComponent();
            numericUpDown1.Value = Convert.ToDecimal(Temperature.Properties.Settings.Default.D1);
            numericUpDown2.Value = Convert.ToDecimal(Temperature.Properties.Settings.Default.D2);
            numericUpDown3.Value = Convert.ToDecimal(Temperature.Properties.Settings.Default.D3);
            numericUpDown4.Value = Convert.ToDecimal(Temperature.Properties.Settings.Default.D4);


        }

        private void button1_Click(object sender, EventArgs e) {

            Temperature.Properties.Settings.Default.D1 = Convert.ToDouble(numericUpDown1.Value);
            Temperature.Properties.Settings.Default.D2 = Convert.ToDouble(numericUpDown2.Value);
            Temperature.Properties.Settings.Default.D3 = Convert.ToDouble(numericUpDown3.Value);
            Temperature.Properties.Settings.Default.D4 = Convert.ToDouble(numericUpDown4.Value);
            Temperature.Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
