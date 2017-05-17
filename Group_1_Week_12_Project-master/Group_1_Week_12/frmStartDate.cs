using System;
using System.Windows.Forms;
using Misc;

namespace Group_1_Week_12 {
    public partial class frmStartDate : Form
    {
        public frmStartDate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            //Event handler for all button click events...
            //Buttons btnSubmit, btnCancel
            if (sender == btnSubmit) {
                if (Validator.IsDateFormat(txtStartDate, "Date")) {
                    if(Validator.IsValidDay(txtStartDate, "Date"))
                    {
                        //if btnSubmit = valid date format, set tag to txtStartDate.Text
                        this.Tag = txtStartDate.Text;

                        //set DialogResult to OK
                        this.DialogResult = DialogResult.OK;
                    }
                   else
                    {
                        //error; focus/select all text
                        txtStartDate.Focus();
                        txtStartDate.SelectAll();
                    }
                }
                else {
                    //error; focus/select all text
                    txtStartDate.Focus();
                    txtStartDate.SelectAll();
                }
            }
            else if (sender == btnCancel) {
                //user cancelled date entry
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
