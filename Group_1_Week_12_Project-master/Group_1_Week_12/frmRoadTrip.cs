using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Misc;
using System.Drawing;
//Group 1: Week 12 Project
//
//          by
//Richard H. Nguyen, Richard H. Anesi, Zachary Schmitz

namespace Group_1_Week_12 {
    public partial class frmRoadTrip : Form
    {
        public frmRoadTrip()
        {
            InitializeComponent();
        }

        //Constant and class-wide variables

        //--------------------------------------
        //Location variables for PictureBox anim
        //--------------------------------------

        int locX = 645,
            locY = 345;

        //MPG assumed to be 30   
        const int mpg = 30;

        //bools used as flags for program logic
        bool firstCity = true, 
            startSet = false;

        //totalMiles, totalTime are accumulators used in
        //the setTextBox method
        int totalMiles = 0, 
            totalTime = 0,
            //counter used for form's animation, determines
            //which pictureBox will be assigned the image    
            counter = 0;

        //accumulator for cost
        decimal totalCost = 0m;

        //startDate = assigned starting date; either today
        //(if no time is given) or the result of the Form
        //frmStartDate
        DateTime startDate;

        //timer used for animation
        private static System.Timers.Timer timer;

        //List of "destinations", added through form
        List<Destination> route = new List<Destination>();

        //Container for all pictureBox objects
        List<PictureBox> pbList;

        

        //Rectangular array used to determine the distance between two cities
        int[,] distanceArray = new int[7, 7] { 
            { 0, 2733, 2015, 1926, 2792, 964, 1437 },   { 2733, 0, 1378, 1789, 1285, 3255, 1312 }, 
            { 2015, 1378, 0, 408, 789, 2121, 967 },     { 1926, 1789, 408, 0, 1197, 1728, 942 }, 
            { 2792, 1285, 789, 1197, 0, 2894, 1548 },   { 964, 3255, 2121, 1728, 2894, 0, 2035 }, 
            { 1437, 1312, 967, 942, 1548, 2035, 0 } };

        //Rectangular array used to determine the length of time spent driving between two cities
        int[,] timeArray = new int[7, 7] { 
            { 0, 38, 29, 27, 40, 16, 21 },  { 38, 0, 20, 26, 19, 47, 19 }, 
            { 29, 20, 0, 6, 12, 31, 14 },   { 27, 26, 6, 0, 19, 25, 14 }, 
            { 40, 19, 12, 19, 0, 42, 23 },  { 16, 47, 31, 25, 42, 0, 29 }, 
            { 21, 19, 14, 14, 23, 29, 0 } };

        private int calculateTime(int x, int y)
        {
            //Returns element indicating hours spent driving.
            return timeArray[x, y];
        }
        private int calculateMiles(int x, int y)
        {
            //Returns element indicating distance
            return distanceArray[x,y];
        }
        private void setTextBox()
        {
            //string to accumulate location information
            string message = "";
            totalCost = 0;
            totalMiles = 0;
            totalTime = 0;

            //foreach loop iterating over each location in the route list
            foreach(Destination destination in route)
            {
                //City + Cost to drive + Distance + Hours until arrival
                message += destination.City + "\n" +
                    "Cost: " + ((destination.Miles / mpg) * destination.GasPrice).ToString() + "\n" +
                    "Distance: " + destination.Miles.ToString() + "\n" +
                    "Hours: " + destination.Time + "\n" + printLine('-') + "\n";

                //quantities sent to respective accumulators
                totalCost += (destination.Miles / mpg) * destination.GasPrice;
                totalMiles += destination.Miles;
                totalTime += destination.Time; 
            }
            if (!startSet)
                //Default start date (today) used
                //time of day defaults to 00:00
                startDate = DateTime.Today;

            //TimeSpan object to determine "arrival" date (hours = totalTime accumulator)
            TimeSpan hours = new TimeSpan(totalTime,0,0);

            //Start Date + Hours = Arrival Time
            DateTime arrival = startDate.Add(hours);

            //append accumulator information to the end of the output string
            message += printLine('_') + 
                "\nMiles:\t\t " + totalMiles.ToString("n0") + 
                "\nCost:\t\t" + totalCost.ToString("c") + 
                "\nHours:\t\t " + totalTime.ToString("n0") + "\n" + 
                "Leave on: " + startDate.ToString("d") + "\n" +
                "Arrive on: " + arrival.ToString("d");

            //set contents of output string to output textbox
            txtOutput.Text = message;
        }
        private string printLine(char c) {
            //generate a line based on the supplied character
            string y = "";
            for (int x = 0; x < 22; x++) {
                y += c;
            }
            return y;
        }
        private void addWaypoint()
        {
            if (Validator.IsPresent(txtGas,"Gas price") && 
                Validator.IsDecimal(txtGas,"Gas price") &&
                Validator.IsValidData(txtGas, "Gas price")) {
                //requires valid gas price entry
                if (firstCity) { //if the destination is the first added, uses default calcMiles/Time methods
                    //used info:
                    //Selected Index of the listCities ListBox
                    //Selected Item of the listCities ListBox
                    //String -> Decimal txtGas Text property
                    //Miles, from calculateMiles
                    //Time, from calculateTime
                    route.Add(new Destination(
                        lstCities.SelectedIndex,
                        lstCities.SelectedItem.ToString(),
                        Convert.ToDecimal(txtGas.Text),
                        0,
                        0));
                    firstCity = false; //no longer first city
                    setTextBox(); //output
                }
                else { //not first destination, use coordinate data to determine the distance/time
                    if (lstCities.SelectedIndex != route[route.Count - 1].Index)
                    {
                        route.Add(new Destination(
                            lstCities.SelectedIndex,
                            lstCities.SelectedItem.ToString(),
                            Convert.ToDecimal(txtGas.Text),
                            calculateMiles(lstCities.SelectedIndex,
                            route[route.Count - 1].Index),
                            calculateTime(lstCities.SelectedIndex,
                            route[route.Count - 1].Index)));
                        setTextBox(); //output
                    }
                    else
                    {
                        MessageBox.Show("Repeat destination selected, please select a new destination.", "Repeated Selection");
                    }
                }
            }
            else {
                //txtGas Text property invalid in some way; focus/select all
                txtGas.Focus();
                txtGas.SelectAll();
            }
        }
        private void frmRoadTrip_Load(object sender, EventArgs e) {
            //initialize animation, change the selected index of lstCities to 0
            animation();
            lstCities.SelectedIndex = 0;
            //Container for all pictureBox objects
            //pbList = new List<PictureBox> { pictureBox7, pictureBox6, pictureBox5, pictureBox4, pictureBox3, pictureBox2 };
        }
        private void Button_Click(object sender, EventArgs e) {
            if (sender == btnClear) {
                //return controls/variables to their initial settings
                txtGas.Text = "2.30";
                txtOutput.Text = "";
                firstCity = true;
                startSet = false;
                totalCost = 0m;
                totalMiles = 0;
                totalTime = 0;
                route.Clear();
            }
            else if (sender == btnStart) {
                //instantiates frmStartDate as DialogBox
                //Tag property = start date
                string temp = "";
                Form setStartDate = new frmStartDate();
                DialogResult btnSubmit = setStartDate.ShowDialog();
                if (btnSubmit == DialogResult.OK) {
                    temp = setStartDate.Tag.ToString();
                    startDate = DateTime.Parse(temp);
                    startSet = true;
                }
            }
            else if (sender == btnExit)
                //exits the program
                this.Close();
            else if (sender == btnAdd)
                //call addWaypoint procedure
                addWaypoint();
        }
        PictureBox anim = new PictureBox();
        public void animation() {
            //
            //timer
            //
            timer = new System.Timers.Timer(1);
            timer.Elapsed += Timer_Trigger;
            timer.Enabled = true;
            //
            //PictureBox 'anim' properties
            //
            anim.Location = new Point(545, 345);
            anim.Size = new Size(100, 50);
            anim.SizeMode = PictureBoxSizeMode.Zoom;
            anim.Image = Properties.Resources.volkswagen_PNG1777;
            anim.Visible = true;
            anim.Enabled = true;
            Controls.Add(anim);
        }
        private void Key_Down(object sender, KeyEventArgs e) {
            //add keyboard controls to animation
            if (e.KeyCode == Keys.Add)
                locY += 5;
            else if (e.KeyCode == Keys.Subtract)
                locY -= 5;
        }       
        private void Timer_Trigger(object sender, System.Timers.ElapsedEventArgs e) {
            //event handler which occurs after timer has elapsed
            if (locX < -150)
                locX = 675;
            //point to send to method
            Point point = new Point(locX, locY);
            Action setLocation = () => anim.Location = point;
            if(anim.InvokeRequired)
                anim.BeginInvoke(setLocation);
            //move left
            locX -= 5;
        }     
    }
    

}
