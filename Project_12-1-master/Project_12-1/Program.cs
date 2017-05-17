using System;
using System.Windows.Forms;
namespace Project_12_1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCalculator());
        }
    }
}
namespace Misc {
    public static class Validator {
        //Static data validation handling class.
        public static bool IsPresent(TextBox tb) {
            //Determines whether the Text property of a TextBox is assigned
            //either an empty string or a null value.
            //
            //Returns false if "nothing" is detected, true otherwise.
            if (tb.Text == "" || tb.Text == null)
                return false;
            return true;
        }
        public static bool IsPresent(string s) {
            //Variant on the TextBox object IsPresent function.
            //Takes a string as an argument.
            if (s == "" || s == null)
                return false;
            return true;
        }
        public static bool InRange(int value, int min, int max) {
            //Determines if the parameter "value" is within range
            //of defined minimum (min) and maximum (max) values.
            //If so, returns true. If not, returns false.
            if (value < min || value > max)
                return false;
            return true;
        }
        public static bool IsPositive(decimal value) {
            if (value < 0)
                return false;
            return true;
        }
        public static bool CanDivide(decimal x, decimal y) {
            //Attempts to divide parameter x by parameter y.
            //If successful, the method will return true.
            decimal z;
            try { z = x / y; return true; }
            catch { z = 0m; return false; }
        }
        public static bool IsValid(string s) {
            //Attempts to parse the contents of a string
            //to a decimal value. Returns true if successful.
            try { decimal.Parse(s); return true; }
            catch { return false; }
        }
        public static void Error(string name, string reason, string title = "Error") {
            //Creates a MessageBox object to inform the user of a specific error.
            //This version lacks TextBox object control.
            MessageBox.Show(name + " is invalid: " + reason  + ".", title);
        }
        public static void Error(TextBox tb, string name, string reason, string title = "Error") {
            //Creates a MessageBox object to inform the user of a specific error.
            //This version will focus on a specific textbox and select the offending
            //input.
            MessageBox.Show(name + " is invalid: " + reason + ".", title);
            tb.SelectAll();
            tb.Focus();
        }
    }
    public class Calculator {
        //Calculator class for the calculator project.
        //
        //2 private fields: currentValue (the value 
        //currently stored) and pendingOperation
        //(a string used in the Equals() method).
        private decimal currentValue;
        private string pendingOperation;
        public Calculator() {
            //initializes default values (0, "")
            Clear();
        } 
        public decimal CurrentValue {
            //Accessor for the currentValue field.
            get { return currentValue; }
            set { currentValue = value; }
        }
        //The following methods set the pending operation.
        //Those operations are: add, subtract, multiply, divide,
        //square root, and reciprocal.
        public void Add() { pendingOperation = "Add"; }
        public void Subtract() { pendingOperation = "Subtract"; }
        public void Multiply() { pendingOperation = "Multiply"; }
        public void Divide() { pendingOperation = "Divide"; }
        public void Reciprocal() { pendingOperation = "Reciprocal"; }
        public void SquareRoot() { pendingOperation = "SquareRoot"; }
        public void Equals(decimal newValue) {
            //Using the pendingOperation field, determine what value
            //the currentValue field should hold.
            switch (pendingOperation) {
                case "Add":
                    //Adds newValue to currentValue.
                    currentValue += newValue;
                    break;
                case "Subtract":
                    //Subtracts newValue from currentValue.
                    currentValue -= newValue;
                    break;
                case "Multiply":
                    //Multiply current value by new value.
                    currentValue *= newValue;
                    break;
                case "Divide":
                    //Divide the current value by the new value.
                    if(Validator.CanDivide(currentValue, newValue)) {
                        //No x/0 error, set value.
                        currentValue /= newValue;
                        break;
                    }
                    //Division by 0 detected, abort calculation.
                    Validator.Error("Calculation", "division by zero", "Division Calculation Error");
                    Clear();
                    break;
                case "Reciprocal":
                    //Calculate the reciprocal of the new value, set current value to new value.
                    if(Validator.CanDivide(1, currentValue)) {
                        //No x/0, set value.
                        currentValue = 1 / newValue;
                        break;
                    }
                    //Division by 0 detected, abort calculation.
                    Validator.Error("Calculation", "division by zero", "Reciprocal Calculation Error");
                    Clear();
                    break;
                case "SquareRoot":
                    //Calculate the square root of the new value, set the current value to the
                    //calculated value.
                    if (Validator.IsPositive(newValue)) {
                        //is real number
                        currentValue = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(newValue)));
                        break;
                    }
                    //is imaginary number
                    Validator.Error("Calculation", "invalid numeric entry", "Exponentiation Error");
                    Clear();
                    break;
            }
        }
        public void Clear() {
            //Set fields to their default values.
            currentValue = 0m;
            pendingOperation = "Add"; //set to avoid format exception
        }
    }
}