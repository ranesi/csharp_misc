using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_19_1a {
    public partial class frmAddModifyCustomers : Form {
        public frmAddModifyCustomers() { InitializeComponent(); }
        private void ToggleEnabled(bool enable) {
            //This method is used to set whether the following controls are enabled
            //
            //ToolStripButtons: 
            //      bnAdd, bnDelete, bnMoveFirst, bnMoveLast, bnMovePrevious, bnMoveNext
            //
            //ToolStripTextBox: 
            //      bnPosition
            //
            foreach (ToolStripButton b in new List<ToolStripButton> {
                bnAdd,bnDelete,bnMoveFirst,bnMoveLast,bnMovePrevious,bnMoveNext}) {
                if (enable)
                    b.Enabled = true;
                else
                    b.Enabled = false;
            }
            bnPosition.Enabled = enable;
        }
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            //Attemps to validate, end edit, and update dataset
            //else throw generic exception
            if (Validate()) {
                try {
                    customersBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(this.techSupportDataSet);
                    if (bnDelete.Enabled == false) ToggleEnabled(true);
                }
                catch (DataException ex) {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }  
            }
        }
        private void frmAddModifyCustomers_Load(object sender, EventArgs e) {
            //Attempts to fill table adapter.
            //Exceptions: SQL Exception, generic exception
            try {
                customersTableAdapter.Fill(techSupportDataSet.Customers);
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (DataException ex) {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void ButtonClick(object sender, EventArgs e) {
            //IF btnOK, set dialog result to ok
            //IF btnCancel, set dialog result to cancel
            if(sender == btnOK) {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (sender == btnCancel) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private void bindingNavigatorCancel_Click(object sender, EventArgs e) {
            //Simply, cancels any edits.
            customersBindingSource.CancelEdit();
            //Enable controls, if necessary
            if (bnDelete.Enabled == false) ToggleEnabled(true);
        }
        private void bnAdd_Click(object sender, EventArgs e) {
            //Disable controls to prevent the user from unintentionally crashing the program
            ToggleEnabled(false);
        }
    }
}