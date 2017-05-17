using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_19_1a {
    public partial class frmCustomerIncidents : Form {
        public frmCustomerIncidents() { InitializeComponent(); }
        private void btnFind_Click(object sender, EventArgs e) {
            if (Validator.IsPresent(txtInput.Text) &&
                Validator.IsInteger(txtInput.Text, true)) {
                //IF the data entered into txtInput TextBox is 1) present and
                //2) able to be parsed to an integer, fill Customer and 
                //Incident table adapters using customerID parameter
                try {
                    int customerID = Convert.ToInt32(txtInput.Text);
                    customersTableAdapter.FillByCustomerID(
                        techSupportDataSet.Customers, customerID);
                    incidentsTableAdapter.FillIncidentsByCustomerID(
                        techSupportDataSet.Incidents, customerID);
                }
                catch (SqlException ex) {
                    MessageBox.Show("SQL Error: " + ex.Message, ex.GetType().ToString());
                }
                catch (DataException ex) {
                    MessageBox.Show("Data error: " + ex.Message, ex.GetType().ToString());
                }
            }
            else {
                //Data entry was invalid; focus on txtInput and select contents
                txtInput.Focus();
                txtInput.SelectAll();
            }
        }
        private void btnSearchState_Click(object sender, EventArgs e) {
            //Instantiate new frmFindCustomer
            Form findCustomer = new frmFindCustomer();
            //Launch dialog
            DialogResult btnOK = findCustomer.ShowDialog();
            if (btnOK == DialogResult.OK) {
                //Convert frmFindCustomer Tag property to string,
                //execute btnFind_Click event to load information into
                //THIS
                txtInput.Text = findCustomer.Tag.ToString();
                btnFind_Click(this, new EventArgs());
            }
        }
        private void ButtonClick(object sender, EventArgs e) {
            if (sender == btnAddNewIncident) {
                if (Validator.IsPresent(customerIDTextBox.Text) &&
                    Validator.IsPresent(nameTextBox.Text)) {
                    //Instantiate new frmAddIncident with customerIDTextBox Text
                    //property as passed parameter
                    Form addIncident = new frmAddIncident(
                        Convert.ToInt32(customerIDTextBox.Text));
                    //Launch dialog
                    DialogResult btnAdd = addIncident.ShowDialog();
                    if (btnAdd == DialogResult.OK) {
                        //Fill incidents by customer ID
                        int customerID = Convert.ToInt32(txtInput.Text);
                        incidentsTableAdapter.FillIncidentsByCustomerID(
                            techSupportDataSet.Incidents, customerID);
                    }
                }
            }
            else if (sender == btnAddModifyCustomers) {
                //Launch add/modify customers form
                Form addModifyCustomers = new frmAddModifyCustomers();
                DialogResult btnOK = addModifyCustomers.ShowDialog();
                if(btnOK == DialogResult.OK) {
                    //If DialogResult is OK, reload current customer IF
                    //1) there is valid input in the input textbox, and
                    //2) the text can be parsed to an integer
                    //
                    //as this is an automatic action, the user will not
                    //be prompted for erroneous data
                    if (txtInput.Text != "" &&
                        Validator.IsInteger(txtInput.Text,false)) {
                        int customerID = Convert.ToInt32(txtInput.Text);
                        customersTableAdapter.FillByCustomerID(
                            techSupportDataSet.Customers, customerID);
                        incidentsTableAdapter.FillIncidentsByCustomerID(
                            techSupportDataSet.Incidents, customerID);
                    }
                }
            }
        }
    }
}
