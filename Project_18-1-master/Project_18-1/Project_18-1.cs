using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_18_1 {
    public partial class frmTechnicians : Form {
        public frmTechnicians() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            //Attempts to populate data grid view with rows from attached .MDF file
            //
            //SQL Errors handled via catch statement
            try {
                this.techniciansTableAdapter.Fill(this.techSupport.Technicians);
            }            
            catch (SqlException ex) {
                MessageBox.Show("Database error #" + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            //Attempts to save changes to table
            //
            //Catches: Database Concurrency, Non-nullable, Data Exception (generic), and SQL Exception
            this.Validate();
            try {
                this.techniciansBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.techSupport);
            }
            catch (DBConcurrencyException) {
                MessageBox.Show("A concurrency error occured. Some rows not updated.", "Concurrency Exception");
            }
            catch (NoNullAllowedException) {
                MessageBox.Show("No nulls allowed exception.", "Non-nullable Error");
            }
            catch (DataException ex) {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                techniciansBindingSource.CancelEdit();
            }
            catch (SqlException ex) {
                MessageBox.Show("Database error #" + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void dgvTechnicians_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            //Data Grid View Error method
            int row = e.RowIndex + 1;
            string error = "Data error!\n" + "Row: " + row + "\n" + "Error: " + e.Exception.Message;
            MessageBox.Show(error, "Data Error");
        }
    }
}
