using System;
using System.Windows.Forms;

namespace Lab_7_Project {
    public partial class frmAddItem : Form {
        public frmAddItem() {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            //adding items to the inventory
            if (sender == btnAdd) {
                if (IsValid(txtUPC) & IsValid(txtQuantity) & IsDate(txtExpirationDate)) {
                    Tag = txtUPC.Text + "|" + txtProductName.Text + "|" + txtQuantity.Text + "|" + txtExpirationDate.Text;//tag to move the data to the other form
                    MessageBox.Show("Product " + txtProductName.Text + " was added successfully", "Item Added");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (sender == btnCancel) {//cancel the entry
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private bool IsValid(TextBox tb) {
            //determines if TextBox Text property is valid numeric data
            long x = 0;
            int y = 0;
            if (long.TryParse(tb.Text, out x) | int.TryParse(tb.Text, out y))
                return true;
            Error("Numeric entry", "format error", tb);
            return false;
        }
        private bool IsDate(TextBox tb) {
            //Determines if TextBox Text property can be converted to a valid date
            DateTime x = new DateTime();
            if (DateTime.TryParse(tb.Text, out x))
                return true;
            Error("Date", "invalid date", tb);
            return false;
        }
        private void Error(string name, string reason, TextBox tb, string title = "Input Error") {
            //Error handling method. States reason for error and focuses on offending TextBox.
            MessageBox.Show(name + " entry is invalid: " + reason + ".", title);
            tb.SelectAll();
            tb.Focus();
        }
    }
}
