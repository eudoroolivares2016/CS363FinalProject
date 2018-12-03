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
    public partial class myCharts : Form
    {
        List<int> bloodSugarLists = new List<int>();
        Boolean endChart = false;
        private Timer _Timer = new Timer();
        private Timer _Timer2 = new Timer();
        public myCharts()
        {
            InitializeComponent();
            this.loadData();
        }

        private void myCharts_Load(object sender, EventArgs e)
        {

            this.loadData();

            bloodSugarLists.Add(Form1.bloodLevel);

            _Timer.Interval = 1000;

            _Timer.Tick += new EventHandler(_Timer_Tick);

            _Timer.Start();

            

            InitTimer();


        }

        void _Timer_Tick(object sender, EventArgs e)
        {
            //string counter = InitTimer();
            this.label1.Text = DateTime.Now.ToString();

            if (endChart == false)
            {
                chart1.Series["bloodSugarLevels"].Color = Color.Blue;
            if(chart1.Series.Count > 5)
            {
                chart1.Series.Clear();
                //chart1.Series.Count = 0;
            }
            chart1.Series["bloodSugarLevels"].Font = new System.Drawing.Font("Arial", 22);



            
                chart1.Series["bloodSugarLevels"].Points.AddXY(DateTime.Now.ToString(), Form1.bloodLevel);
            }
            
            //string counter = InitTimer();

          //  this.timeLabel.Text = InitTimer() ;

        }
        void _Timer2_Tick(object sender, EventArgs e)
        {

          //  this.timeLabel.Text = InitTimer();
           
        }



        public String InitTimer()
        {
            int counter = 10 ;
            _Timer2 = new Timer();
            _Timer2.Tick += new EventHandler(_Timer2_Tick);
            _Timer2.Interval = 1000; // in miliseconds
            //_Timer2.Start();



            if (counter > 0)
            {

                counter--;
            }
            else
            {

                counter = 10;
            }

           return  counter.ToString();
        }



        public void loadData()
        {
            //TODO put blood sugars into array and plot them accordingly


            /*  chart1.Series["bloodSugarLevels"].Points.AddXY("Time1", "8");
              chart1.Series["bloodSugarLevels"].Points.AddXY("Time2", "10");
              chart1.Series["bloodSugarLevels"].Points.AddXY("Time3", "12");
              chart1.Series["bloodSugarLevels"].Points.AddXY("Time4", "15");
              chart1.Series["bloodSugarLevels"].Points.AddXY("Time5", "25");
      */

           




        }

        private void chart1_Click(object sender, EventArgs e)
        {

            //this.loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            endChart = true;
            this.Close();
        }
    }
}
