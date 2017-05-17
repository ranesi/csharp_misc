using System;
using System.Windows.Forms;
using Misc;
/*******************************************************************************
|                       2505-01 PROJECT 12-1, Calculator                       |
|                             By: Richard H Anesi                              |
|------------------------------------------------------------------------------|
|                                                                              |
*******************************************************************************/
namespace Project_12_1 {
    public partial class frmCalculator : Form {
        public frmCalculator() {
            InitializeComponent();
        }
        //Instantiates a new calculator object (calc) using the calculator class
        //contained in namespace Misc.
        //
        //Class located in Program.cs file.
        Calculator calc = new Calculator();
        //output string which builds the numeric entry to feed to 
        string output = "";
        bool decimalPresent = false, isNegative = false;
        private void PerformCalculation() {
            //Calculates the value
            if (!Validator.IsPresent(txtOutput))
                //Sends value of 0 when no information is entered.
                calc.Equals(0);
            else
                //Data found in txtOutput
                calc.Equals(decimal.Parse(txtOutput.Text));
            //Send stringified currentValue to txtOutput Text property.
            txtOutput.Text = calc.CurrentValue.ToString();
            //"Reset" output and decimalPresent.
            output = "";
            decimalPresent = false;
        }
        private void ToTextBox(decimal input) {
            //Concatenates the input parameter to string output, then sets the Text property of txtOutput to
            //string output. This overloaded method is for numeric (decimal) data ONLY.
            output += input.ToString();
            txtOutput.Text = output;
        }
        private void ToTextBox(string input) {
            //Concatenates the input parameter to string output, then sets the Text property of txtOutput to
            //string output. This overloaded method is for non-numeric data.
            output += input;
            txtOutput.Text = output;
        }
        private void Clear() {
            //Returns the calc Calculator object, the decimalPresent boolean, the output string, and the Text
            //property of txtOutput to a more or less quiescent state.
            calc.Clear();
            decimalPresent = false;
            isNegative = false;
            output = "";
            txtOutput.Text = null;
        }
        private void TrimPeriod() {
            //Removes the decimal point from an entry if no numeric characters follow.
            if (output.Length > 0 && output[output.Length - 1] == '.') 
                output = output.Substring(0, output.Length - 1);           
        }

        private void Key_Down(object sender, KeyEventArgs e) {
            //This is the event handler for KeyDown events.
            int counter = 0;
            foreach (Keys key in new Keys[] {Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 }) {
                if (e.KeyCode == key)
                    ToTextBox(counter);
                counter++;
            }
            if (e.KeyCode == Keys.Back)
                btnBack.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                btnClear.PerformClick();
            else if (e.KeyCode == Keys.Decimal)
                btnDecimal.PerformClick();
            else if (e.KeyCode == Keys.Add)
                btnAddition.PerformClick();
            else if (e.KeyCode == Keys.Subtract)
                btnSubtract.PerformClick();
            else if (e.KeyCode == Keys.Multiply)
                btnMultiply.PerformClick();
            else if (e.KeyCode == Keys.Divide)
                btnDivide.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                btnEquals.PerformClick();
        }

        private void Button_Click(object sender, EventArgs e) {
            int counter = 0;
            foreach (Button button in new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 }) {
                //This loop instantiates a new button array, iterates over each, determines IF one is the sender,
                //then calls the ToTextBox method using the incrementing value counter as the argument.
                if (sender == button)
                    ToTextBox(counter);
                counter++;
            }
            if (sender == btnDecimal) {
                //Uses the decimalPresent boolean variable
                //If decimalPresent is FALSE, will add a decimal
                if (!decimalPresent) {
                    ToTextBox(".");
                    decimalPresent = true;
                }
            }
            else if (sender == btnPositiveNegative) {
                //Really, adds a '-' in index 0 of string
                //output IF the length of output is > 0.
                if (output.Length > 0) {
                    if (!isNegative) {
                        output = output.Insert(0, "-");
                        txtOutput.Text = output;
                        isNegative = true;
                    }
                    else {
                        output = output.Remove(0, 1);
                        txtOutput.Text = output;
                        isNegative = false;
                    }
                }
            }
            else if (sender == btnBack) {
                //Reassigns the string variable output to a substring from index 0 to the final index (output.Length - 1).
                //Afterwards, sets the Text property of txtOutput to string output.
                if (output.Length > 0)
                    output = output.Substring(0, output.Length - 1);
                txtOutput.Text = output;
            }
            else if (sender == btnClear) {
                //Calls the Clear() method.
                Clear();
            }
            /////////////CALCULATION BUTTON EVENTS//////////////
            if (sender == btnAddition | sender == btnSubtract | sender == btnMultiply | sender == btnDivide | sender == btnSquareRoot | sender == btnReciprocal) {
                //sets the queued operation to add, subtract, multiply, divide
                if (sender == btnAddition)
                    calc.Add();
                else if (sender == btnSubtract)
                    calc.Subtract();
                else if (sender == btnMultiply)
                    calc.Multiply();
                else if (sender == btnDivide)
                    calc.Divide();
                else if (sender == btnSquareRoot)
                    calc.SquareRoot();
                else if (sender == btnReciprocal)
                    calc.Reciprocal();
                TrimPeriod(); //removes decimal point if no digits are present afterward
                if (!Validator.IsPresent(txtOutput))
                    //Sends value of 0 when no information is entered.
                    calc.CurrentValue = 0;
                else
                    //Data found in txtOutput
                    calc.CurrentValue = decimal.Parse(txtOutput.Text);
                //Reset necessary fields.
                output = "";
                decimalPresent = false;
            }
            else if (sender == btnEquals) {
                //Removes decimal point if no digits present afterward.
                TrimPeriod();
                //Call PerformCalculation procedure.
                PerformCalculation(); 
            }
        }
    }
}
