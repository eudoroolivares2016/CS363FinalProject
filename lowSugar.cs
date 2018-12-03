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
    public partial class lowSugar : Form
    {
        public lowSugar()
        {
            InitializeComponent();
            System.Media.SystemSounds.Beep.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lowSugar_Load(object sender, EventArgs e)
        {

        }
    }
}
