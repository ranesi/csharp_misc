using System;
using System.Windows.Forms;

namespace Project_12_2 {
    public static class Validator {
        public static bool IsInt(TextBox tb) {
            //If passed string is parsable to integer, returns true
            try {
                int.Parse(tb.Text);
                return true;
            }
            catch {
                Error(tb, "data not in valid numeric format","Invalid Numeric Entry");
                return false;
            }
        }
        public static bool IsDateTime(TextBox tb) {
            //If passed string is parsable to DateTime, returns true
            try {
                DateTime.Parse(tb.Text);
                return true;
            }
            catch {
                Error(tb, "data not in valid date/time format", "Invalid Time Entry");
                return false;
            }
        }
        public static bool InRange(TextBox tb, int min, int max) {
            //If passed integer is within args minimum/maximum, return true
            if (IsInt(tb) && 
                Convert.ToInt32(tb.Text) >= min && 
                Convert.ToInt32(tb.Text) <= max)
                return true;
            Error(tb, "value out of range");
            return false;
        }
        public static bool IsPresent(TextBox tb) {
            //If passed string returns 
            if (tb.Text == "" | tb.Text == null) {
                Error(tb, "no text entered");
                tb.Focus();
                return false;
            }
            return true;
        }
        public static DateTime RemoveSeconds(DateTime d) {
            //Removes seconds and milliseconds from a DateTime value
            d = d.AddSeconds(-d.Second);
            d = d.AddMilliseconds(-d.Millisecond);
            return d;
        }
        public static bool ValidTimes(DateTime start, DateTime end) {
            //ensures start time is before end time, end time after start time
            if (end < start | start > end) { Error("Please select a valid time", "Time selection invalid"); return false; }
            return true;
        }
        public static bool IsToday(DateTime dt) {
            //returns true if date is today
            if (dt.Day == DateTime.Now.Day && dt.Month == DateTime.Now.Month) return true;
            Error("date must be today");
            return false;
        }
        public static void Error(TextBox tb, string err, string title = "Error") {
            //error - selects textbox
            MessageBox.Show("Error found: " + err + ".", title);
            tb.Focus();
            tb.SelectAll();
        }
        public static void Error(string err, string title = "Error") {
            //error - generic method - displays text
            MessageBox.Show("Error found: " + err + ".", title);
        }
    }
}
