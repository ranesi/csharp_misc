using System;
using System.Windows.Forms;
namespace Project_12_2 {
    public partial class frmOptions : Form {
        public frmOptions() { InitializeComponent(); }
        private void ButtonClick(object sender, EventArgs e) {
            if(Validator.IsPresent(txtFirstTicketNumber) && Validator.IsInt(txtFirstTicketNumber) &&
                Validator.ValidTimes(dtpStartTime.Value,dtpEndTime.Value) &&
                Validator.IsToday(dtpStartTime.Value) && Validator.IsToday(dtpEndTime.Value)) {
                //add the contents of the various Control objects to frmOptions' Tag property,
                //set dialogresult to OK
                this.DialogResult = DialogResult.OK;
                this.Tag = 
                    nudMinutesPerWindow.Text + "|" + 
                    nudGuestsPerWindow.Text + "|" + 
                    dtpStartTime.Value.ToString() + "|" + 
                    dtpEndTime.Value.ToString() + "|" + 
                    txtFirstTicketNumber.Text;
                this.Close();
            }
        }

        private void frmOptions_Load(object sender, EventArgs e) {
            //set datetimepicker objects - starttime = now; endtime = today at 6PM
            dtpStartTime.Value = Validator.RemoveSeconds(DateTime.Now);
            dtpEndTime.Value = Validator.RemoveSeconds(new DateTime(
                DateTime.Now.Year, 
                DateTime.Now.Month, 
                DateTime.Now.Day, 
                18, //hour
                0,  //minute
                0)); //second
        }
    }
}