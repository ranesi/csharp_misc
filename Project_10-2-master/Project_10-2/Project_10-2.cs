using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10_2 {
    public partial class LunchOrder : Form {
        public LunchOrder() {
            InitializeComponent();
        }
        const decimal salesTax = 0.0775m; //value used for sales tax calculation
        decimal total = 0m;
        private void SetOutput() {
            //Method sets TextBox.Text properties and calculates totals
            //derived from the SetPrice() and NumberChecked() functions
            decimal[] price = CalcPrice();
            decimal subtotal = price[0] + (price[1] * NumChecked());
            total += subtotal;
            decimal taxTotal = total * salesTax, 
                    orderTotal = total + taxTotal;
            
            foreach(KeyValuePair<TextBox, decimal> output in new Dictionary<TextBox,decimal> 
                { { txtItemTotal, subtotal}, { txtSubtotal, total }, { txtTax, taxTotal}, { txtOrderTotal, orderTotal} })
                //this loop pairs all three TextBox objects with the applicable decimal values in a KeyValuePair,
                //setting the Text property for the Key to the associated decimal Value 
                output.Key.Text = string.Format("{0:c}", output.Value);            
        }
        private int NumChecked() {
            //This method determines the number of CheckBoxes checked, 
            //then returns an integer representing that value.
            int counter = 0;
            foreach (CheckBox cb in new CheckBox[] { checkBox1, checkBox2, checkBox3 }) {
                if (cb.Checked)
                    counter += 1;
            }
            return counter;
        }
        private decimal[] CalcPrice() {
            //Returns a 2-element decimal array containing the price
            //calculated by decrementing the maximum price for the
            //main course and add-ons.
            decimal[] price = { 6.95m, 0.75m };
            foreach (RadioButton rb in new RadioButton[] { rdoHamburger, rdoPizza, rdoSalad }) {
                if (rb.Checked)
                    break;
                price[0] -= 1m;
                price[1] -= 0.25m;
            }
            return price;
        }
        private void ClearTextBoxText() {
            //Clears all TextBox objects - this is called when the user clicks on a new RadioButton.
            foreach (TextBox tb in new TextBox[] { txtItemTotal, txtTax, txtOrderTotal })
                tb.Text = null;
        }
        private void SetCheckboxCheck(bool value) {
            foreach (CheckBox chk in new CheckBox[] { checkBox1, checkBox2, checkBox3 })
                chk.Checked = value;
        }
        private void SetAddonGroupBoxText(decimal price) {
            gbAddon.Text = string.Format("Add-on Items ({0:c} /ea.)", price);
        }
        private void AddListItem() {
            //This method generates values to add to the ListBox lbOrderItems
            string[] temp = new string[3];
            string toList = "";
            foreach (RadioButton menuItem in new RadioButton[] { rdoHamburger, rdoPizza, rdoSalad }) {
                if (menuItem.Checked)
                    temp = menuItem.Text.Split(' ');
            }
            toList += temp[0].ToUpper();
            string addonsToList = "";
            if (NumChecked() > 0) {
                addonsToList += "          ADD-ONS: ";
                foreach (CheckBox addonItem in new CheckBox[] { checkBox1, checkBox2, checkBox3 }) {
                    if (addonItem.Checked)
                        addonsToList += addonItem.Text.ToLower() + ", ";
                }
            }
            string totalToList = "          TOTAL: ";
            decimal[] price = CalcPrice();
            totalToList += (price[0] + (price[1] * NumChecked())).ToString("c");
            foreach (string s in new string[] { toList, addonsToList, totalToList }) {
                if (s == addonsToList) {
                    if (NumChecked() > 0)
                        lbOrderItems.Items.Add(s);
                }
                else
                    lbOrderItems.Items.Add(s);
            }
                      
        }
        private void Button_Click(object sender, EventArgs e) {
            //This method determines which Button object triggered the event; 
            //it then either calls SetOutput(), begins closing the Form,
            //or calls ClearTextBoxText() / SetCheckBoxCheck(bool) / clears
            //txtSubtotal TextBox Text property to null / resets the
            //class-scope variable total to 0.
            if (sender == btnPlaceOrder) {
                ClearTextBoxText();
                SetCheckboxCheck(false);
                txtSubtotal.Text = null;
                lbOrderItems.Items.Clear();
                total = 0;
            }
            else if (sender == btnAddItem) {
                SetOutput();
                AddListItem();
                lbOrderItems.Items.Add(" ");
                SetCheckboxCheck(false);
            }
            else if (sender == btnExit) {
                this.Close();
            }
        }
        private void Radio_Checked(object sender, EventArgs e) {
            //When a user selects a RadioButton, this method will set the CheckBox Text
            //properties to the appropriate value.
            //It will also clear the TextBox Text properties for txtSubtotal, txtTax, and
            //txtOrderTotal.
            string[,] addonItems = new string[,] { 
                { "Lettuce, tomato, onions", "Mayo and mustard", "French fries" },
                { "Pepperoni", "Sausage", "Olives" },
                { "Croutons", "Bacon bits", "Breadsticks" } };
            CheckBox[] chk = new CheckBox[] { checkBox1, checkBox2, checkBox3 };
            decimal[] price = CalcPrice();
            int i = 0;

            foreach(RadioButton food in new RadioButton[] { rdoHamburger, rdoPizza, rdoSalad }) {
                if (sender == food) 
                    for(int j = 0; j < 3; j++)
                        chk[j].Text = addonItems[i, j];
                i++;
            }
            SetAddonGroupBoxText(price[1]);
            SetCheckboxCheck(false);
        }      
    }
}