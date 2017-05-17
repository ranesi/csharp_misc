using System;
using System.Windows.Forms;

namespace Project_19_1a {
    public partial class frmFindCustomer : Form {
        //Field to store value in selected cell.
        string value;
        public frmFindCustomer() { InitializeComponent(); }
        private void fillByStateToolStripButton_Click(object sender, EventArgs e) {
            if (txtInput.Text != "") {
                //Fill customers by string (state code)
                //Query:
                //SELECT * FROM Customers WHERE Customers.State LIKE (@State + '%')
                try {
                    customersTableAdapter.FillByState(techSupportDataSet.Customers, txtInput.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else {
                //The same as above, but with characters omitted (empty string)
                try {
                    customersTableAdapter.FillByState(techSupportDataSet.Customers, "");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        private void SetTag() {
            //Sets the tag of the form to equal the value of the FIELD (string) value
            if (customersDataGridView.SelectedCells.Count > 0 &&
                    Validator.IsInteger(value, false)) {
                Tag = value;
            }
            else
                Validator.Error("no row selected", "Error");
        }
        private void ButtonClick(object sender, EventArgs e) {
            //
            if (sender == btnOK) {
                //Set dialog result to ok, close form
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (sender == btnCancel) {
                //not necessary at the moment but added for thoroughness
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private void CellClick(object sender, DataGridViewCellEventArgs e) {
            //if a cell is selected (NOT including the headers), set field (string) value to
            //contents of customer ID to pass back to main form
            if (e.RowIndex > -1)
                value = customersDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            //if the cell double clicked is NOT a header...
            //perform the cell click event
            //call the set tag method
            //perform a click on btnOK Control
            if (e.RowIndex > -1) {
                CellClick(this, new DataGridViewCellEventArgs(
                    customersDataGridView.CurrentCell.ColumnIndex,
                    customersDataGridView.CurrentRow.Index));
                SetTag();
                btnOK.PerformClick();
            }
        }
    }
}
