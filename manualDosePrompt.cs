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
    public partial class manualDosePrompt : Form
    {
        public manualDosePrompt()
        {
            InitializeComponent();
            label3.Text = manualDose.insulin.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            deliverySuccess myDeliverySuccess = new deliverySuccess();
            myDeliverySuccess.Show();
            //rm1.bloodLevel
           // Form1.insulinResovouirLevles -= (int) manualDose.insulin; //trunkates the value

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void manualDosePrompt_Load(object sender, EventArgs e)
        {

        }
    }
}
