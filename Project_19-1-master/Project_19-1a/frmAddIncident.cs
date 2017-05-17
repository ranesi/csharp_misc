using System;
using System.Data;
using System.Windows.Forms;

namespace Project_19_1a {
    public partial class frmAddIncident : Form {
        //FIELD: customerID - used to store passed int parameter
        int customerID;
        public frmAddIncident(int custID) {
            //Initialize form and set customerID field to parameter
            InitializeComponent();
            customerID = custID;
        }
        private void frmAddIncident_Load(object sender, EventArgs e) {
            //Select NOTHING in ComboBox
            cmbProduct.SelectedIndex = -1;
            //Tries to fill Table Adapters (Customers, Incidents, Products);
            //throws exception if unsuccessful
            try {
                customersTableAdapter.FillByCustomerID(techSupportDataSet.Customers, customerID);
                incidentsTableAdapter.Fill(techSupportDataSet.Incidents);
                productsTableAdapter.FillByRegistration(techSupportDataSet.Products, customerID);
            }
            catch (DataException ex) {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void ButtonClick(object sender, EventArgs e) {
            if (sender == btnAdd) {
                if (Validator.IsPresent(txtTitle.Text) &&
                    Validator.IsPresent(txtDescription.Text)) {
                    //IF data is present in Title & Description TextBoxes,
                    //tries to insert into Incidents Table
                    try {
                        incidentsTableAdapter.InsertIntoIncidents(
                            Convert.ToInt32(txtCustomerID.Text),
                            cmbProduct.SelectedValue.ToString(),
                            null,
                            DateTime.Now,
                            null,
                            txtTitle.Text,
                            txtDescription.Text);
                        //End the edit and update the DataSet
                        incidentsBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(techSupportDataSet);
                    }
                    catch (DataException ex) {
                        //Generic data exception handler.
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    //Operation successful; set DialogResult to OK
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (sender == btnCancel) {
                //Aborts edit, sets DialogResult to Cancel, Closes form
                incidentsBindingSource.CancelEdit();
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}