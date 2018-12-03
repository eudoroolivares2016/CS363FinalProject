using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace FinalProject
{
    



    public partial class Form1 : Form
    {
        Boolean generateBloodSugarValues = false;
        public static int bloodLevel = 100;
        public static int insulinResovouirLevles = 100;

        int counter1;
        int counter2;

        string[] passedInArgs = Environment.GetCommandLineArgs();


        private Timer _Timer = new Timer();
        private Timer _Timer2 = new Timer();

        private Timer bloodSugarTimer = new Timer();

        /*    

            TODO: check for conditions/menu choice 
            if(choice 1 ):
                formX.show();




    */

        public void Form1_Load(object sender, EventArgs e)
        {



            control controller = new control();
            controller.Show();
          //  progressBar1.Value = insulinResovouirLevles;
          

            _Timer.Interval = 1000;

            _Timer.Tick += new EventHandler(_Timer_Tick);

            _Timer.Start();


   



          


        }

        void _Timer_Tick(object sender, EventArgs e)
        {
            this.bloodSugarLabel.Text = bloodLevel.ToString() + " mmol/L";



            if (progressBar1.Value == 100)
            {
                progressBar1.ForeColor = Color.Blue;
            }




            if (progressBar1.Value == 0)
            {


                reservoirEmpty empty = new reservoirEmpty();

                //MessageBox.Show("Replace Resovouir");
                empty.Show();
                progressBar1.Value = 100;
            }

            if (progressBar1.Value == 100)
            {
                progressBar1.ForeColor = Color.Blue;
                ReservoirLabel.Text = "Full";

            }
            else if(progressBar1.Value == 50)
            {

                ReservoirLabel.Text = "Half Remaining";
                ReservoirLabel.ForeColor = Color.DarkOrange;
                progressBar1.ForeColor = Color.Orange;
            }


            else if(progressBar1.Value == 25)
            {
                //lowResovouir lowRes = new lowResovouir();
                //lowRes.Show();
                ReservoirLabel.Text = "Low Replace Soon";
                ReservoirLabel.ForeColor = Color.Maroon;
                progressBar1.ForeColor = Color.Red;
            }






           // progressBar3.Value = bloodLevel;
            this.label1.Text = DateTime.Now.ToString();
            counter1++;

                if(counter1 % 5 == 0 && generateBloodSugarValues == true )
            {




               Random rand = new Random();
                Random sign = new Random();

                int nextBloodSugarChange = rand.Next(1,35) ;


                int nextSignForBloodSugarChange = sign.Next(0,2);


                if (nextSignForBloodSugarChange == 0)
                {
                    bloodLevel += nextBloodSugarChange;

                }
                else if(nextSignForBloodSugarChange == 1)
                {

                    bloodLevel -= nextBloodSugarChange;
                }


                if (bloodLevel < 60)
                {
                    lowSugar low = new lowSugar();
                    //MessageBox.Show("WARNING BLOOD SUAGAR LEVEL IS TOO LOW, INJEST SUGAR IMMEDIADLY");
                    low.Show();

                    bloodLevel = 100;
                  


                    bloodSugarLabel.Text = bloodLevel.ToString();


                    


                }



                if (bloodLevel > 110)
                {
                    highBloodSugar high = new highBloodSugar();


                    //MessageBox.Show("WARNING BLOOD SUGAR LEVELS ARE TOO HIGH INJECTING iNUSLIN");

                    high.Show();
                    
                    bloodLevel = 100;
                    bloodSugarLabel.Text = bloodLevel.ToString();
                   progressBar1.Value -= 25;
                    

                    if(progressBar1.Value == 100)
                    {
                        progressBar1.ForeColor = Color.Blue;
                    }

                   if(progressBar1.Value == 0)
                    {


                        reservoirEmpty empty = new reservoirEmpty();

                        //MessageBox.Show("Replace Resovouir");
                        empty.Show();
                        progressBar1.Value = 100;
                    }


                }


                if (battery.Value > 0)
                {
                    battery.Value -= 5;
                }


                if(battery.Value > 50)
                {

                    battery.ForeColor = Color.LightSkyBlue;
                }


                if (battery.Value < 50 )
                {
                    battery.ForeColor = Color.Orange;

                }

               if(battery.Value < 15)
                {
                    LowBattery lowBattery = new LowBattery();
                    lowBattery.Show();
                   // MessageBox.Show("warning low battery");
                    battery.ForeColor = Color.Red;

                }

                if (battery.Value < 5)
                {
                    LowBattery lowBattery = new LowBattery();
                    lowBattery.Show();
                    MessageBox.Show("Changing Battery");

                    battery.Value = 100;
                }


            }






        }




        




       





        public Form1()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            messageDoctor myMessageDoctor = new messageDoctor();
            myMessageDoctor.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            manualDose myManualDose = new manualDose();
            myManualDose.Show();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            helpSearch myHelpSeach = new helpSearch();
            myHelpSeach.Show();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 25;
             

        }

        private void button3_Click(object sender, EventArgs e)
        {
 

            myCharts myFrom4 = new myCharts();
            myFrom4.Show();



        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

            //progressBar2.ForeColor =
            battery.Value += 3;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            profileSettings myProfileSettings = new profileSettings();
            myProfileSettings.Show();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bluetoothSettings myBluetoothSettings = new bluetoothSettings();
            myBluetoothSettings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wifiSettings myWifiSettings = new wifiSettings();
            myWifiSettings.Show();
        }

        private void Enabled_Click(object sender, EventArgs e) //toggles random vaues in 
        {


            generateBloodSugarValues = !generateBloodSugarValues;


        }
    }







    public partial class Form2 : Form
    {



    }







    public partial class Form3 : Form //Low Battery 
    {

        //TODO form that shows low battery warning *maybe will edit the battery on the main page of the device*

    }





    public partial class insulinReplacePage : Form //Replacing insulin
    {

        //Form showing insulin being replaced 

    }



    public partial class injectInsulinPage : Form //Injecting Insulin
    {

        //TODO show current blood sugar levels and then lower the value after insulin is injected
        //TODO *maybe have some kind of like progress bar to show the insulin being injected (maybe a circular one?)*
    

    }



    public partial class chartsPage : Form //Get the charts
    {

        //TODO show a current blood level which every X amount of time (10 seconds?) will raise from a random number between some set parameteres
        //TODO *display that number on a graph if possible*
        //TODO if the value exceeds some hardcoded value, then open the injecting insulin form and then lower the number back down


        private void chartsPage_Load(object sender, EventArgs e)
        {






        }


        private void labe19_Click(object sender, EventArgs e)
        {

        }


    }


    public partial class replaceResovouirPage : Form //replace resovouir 
    {

        //TODO: show warning that the resovouir needs to be replaced have a button that then once pressed acknowledges and "replaces the recovouir" 


    }




    public partial class Form7 : Form //
    {





    }


    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }




}
