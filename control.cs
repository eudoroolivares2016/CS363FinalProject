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
    public partial class control : Form
    {
        public control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removalOfTheNeedle myNeedleRemoval = new removalOfTheNeedle();
            myNeedleRemoval.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insulinPumpFailure myPumpFailure = new insulinPumpFailure();
            myPumpFailure.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            needleFailing myNeedleFailure = new needleFailing();
            myNeedleFailure.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sensorFailing mySensorFailure = new sensorFailing();
            mySensorFailure.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            removalOfResovoiur myReservoirRemoval = new removalOfResovoiur();
            myReservoirRemoval.Show();
        }

        private void control_Load(object sender, EventArgs e)
        {

        }
    }
}
