using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class manualDose : Form
    {
       public static decimal insulin;
        public manualDose()
        {
            InitializeComponent();
            insulin = numericUpDown1.Value;
            numericUpDown1.Maximum = Form1.insulinResovouirLevles;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insulin = numericUpDown1.Value;
            manualDosePrompt myManualDosePrompt = new manualDosePrompt();
            myManualDosePrompt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Form1.insulinResovouirLevles;
           
        }
    }
}
