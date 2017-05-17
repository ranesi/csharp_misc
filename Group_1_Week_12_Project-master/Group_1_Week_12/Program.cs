using System;
using System.Windows.Forms;

namespace Group_1_Week_12 {
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRoadTrip());
        }
    }
}
namespace Misc {

    public class Destination
    {
        //FIELDS
        //Index     :   16-bit integer, PK
        //City      :   string containing name of city
        //GasPrice  :   decimal
        //Miles     :   16-bit integer
        //Time      :   16-bit integer representing hours
        string city;
        int index;
        decimal gasPrice;
        int miles;
        int time;
        public Destination(int Index, string City, decimal GasPrice, int Miles, int Time)    
        {
            //Constructor   :   int, string, decimal, int, int
            //              :   Index, City, GasPrice, Miles, Time
            index = Index;
            city = City;
            gasPrice = GasPrice;
            miles = Miles;
            time = Time;
        }
        public int Index //index property
        {
            get { return index; }
            set { index = value; }
        }
        public string City //city property
        {
            get { return city; }
            set { city = value; }
        }
        public decimal GasPrice //GasPrice property
        {
            get { return gasPrice; }
            set { gasPrice = value; }
        }
        public int Miles //Miles property
        {
            get { return miles; }
            set { miles = value; }
        }
        public int Time //Time property
        {
            get { return time; }
            set { time = value; }
        }
    }

    public static class Validator
    {
        //Static class used for data validation.

        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(TextBox textbox, string name)
        {
            //determines whether a TextBox has data entered
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is required.", title);
                textbox.Focus();
                return false;
            }
            else
                return true;
        }
        public static bool IsDateFormat(TextBox textbox, string name)
        {
            //determines whether the Text property of a TextBox can be parsed to DateTime
            DateTime tripDate;
            if (DateTime.TryParse(textbox.Text, out tripDate))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter mm/dd/yyyy date format in the " + name + " textbox.", title);
                textbox.Focus();
                return false;
            }

        }
        public static bool IsDecimal(TextBox textbox, string name)
        {
            //Determines whether the Text property of a TextBox can be parsed to Decimal
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " needs to be a decimal.", title);
                textbox.Focus();
                return false;
            }
        }

        public static bool IsValidDay(TextBox textBox, string name)
        {
            //Determines if the date entered is after or equal to today's date.
            DateTime tripDate;
            DateTime.TryParse(textBox.Text, out tripDate);

            if (tripDate < DateTime.Today)
            {
                MessageBox.Show("Please enter a date that has not occured yet.", title);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsValidData(TextBox textBox, string name)
        {
            //Determines if the data entered is within 0.01 and 4.00 for gasPrice validation
            double data;
            Double.TryParse(textBox.Text, out data);
            if (data <= 0)
            {
                MessageBox.Show(name + " needs to be greater then $0.00", title);
                return false;
            } else if (data > 4)
            {
                MessageBox.Show(name + " needs to be less than $4.00", title);
                return false;
            } else
            {
                return true;
            }
        }
    }
}