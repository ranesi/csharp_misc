using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Project_18_2_ForReal {
    public partial class frmProductMaintenance : Form {
        public frmProductMaintenance() {
            InitializeComponent();
        }
        private void ToggleEnabled(bool enable) {
            //Toggles enabled/readonly properties for controls on form
            foreach (ToolStripButton b in new List<ToolStripButton> {
                bnAdd, bnDelete, bnMoveFirst,bnMovePrevious,btnFind,btnFillRemainder}) {
                if (enable)
                    b.Enabled = true;
                else
                    b.Enabled = false;
            }
            bnPosition.Enabled = enable;
            txtInput.Enabled = enable;
            productCodeTextBox.ReadOnly = !productCodeTextBox.ReadOnly;
        }
        private bool IsPresent(ToolStripTextBox tb) {
            //Checks if text property of text box is neither an empty string nor null
            if (tb.Text != "" & tb.Text != null) {
                return true;
            }
            MessageBox.Show(tb.Name + " contains no data", "No Data");
            tb.Focus();
            return false;
        }
        private bool IsPresent(TextBox tb) {
            //Checks if the text property of a text box is neither an empty string nor null
            if (tb.Text != "" & tb.Text != null) {
                return true;
            }
            MessageBox.Show(tb.Name + " contains no data", "No Data");
            tb.Focus();
            return false;
        }
        private bool IsValid(ToolStripTextBox tb) {
            //Ensures length of entered text fits within database's requirements
            if (tb.Text.Length <= 8 & tb.Text.Length > 0) {
                return true;
            }
            MessageBox.Show(tb.Name + "'s entry is too long", "Error");
            tb.Focus();
            tb.SelectAll();
            return false;
        }
        private bool IsValid(TextBox tb) {
            //Ensures length of entered text fits within database's requirements
            //OVERLOAD
            if (tb.Text.Length <= 8 & tb.Text.Length > 0) {
                return true;
            }
            MessageBox.Show(tb.Name + "'s entry is too long", "Error");
            tb.Focus();
            tb.SelectAll();
            return false;
        }
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            if (IsPresent(productCodeTextBox) &&
                IsPresent(nameTextBox) &&
                IsPresent(versionTextBox) &&
                IsPresent(releaseDateTextBox)) {
                //Validate everything, end edit, update table adapter
                Validate();
                ToggleEnabled(true);
                productsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(techSupportDataSet);
            }
            else {
                productsBindingSource.CancelEdit();
                ToggleEnabled(true);
            }
        }

        private void Form_Load(object sender, EventArgs e) {
            //Select all from table at form load
            productsTableAdapter.Fill(techSupportDataSet.Products);
        }

        private void btnFind_Click(object sender, EventArgs e) {
            //Simple parameterized query to load a result set by ProductCode
            if (IsPresent(txtInput) && IsValid(txtInput)) {
                try {
                    productsTableAdapter.FillByProductCode(techSupportDataSet.Products, txtInput.Text);
                }
                catch (SqlException ex) {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (DataException ex) {
                    MessageBox.Show("Data exception: " + ex.Message, ex.GetType().ToString());
                }
            }
        }
        private void btnFillRemainder_Click(object sender, EventArgs e) {
            //Fills table according to the following parameterized query
            //SELECT * FROM Products WHERE ProductCode = @ProductCode
            //UNION
            //SELECT * FROM Products WHERE ProductCode <> @ProductCode
            if (IsPresent(txtInput) && IsValid(txtInput)) {
                try {
                    //THIS DOES NOT FILL BY CUSTOMER ID it is mislabeled
                    productsTableAdapter.FillByCustomerIDUnion(techSupportDataSet.Products, txtInput.Text);
                }
                catch (SqlException ex) {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (DataException ex) {
                    MessageBox.Show("Data exception: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            //Disable controls to prevent madnessssss
            ToggleEnabled(false);
            productCodeTextBox.Focus();
        }

        private void bnMoveClick(object sender, EventArgs e) {
            nameTextBox.Focus();
        }
    }
}
