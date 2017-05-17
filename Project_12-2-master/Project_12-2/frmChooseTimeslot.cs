using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Project_12_2 {
    public partial class frmChooseTimeslot : Form {
        //TimeSlot object list populated from frmTicketAssign slotList
        List<TimeSlot> _tsList = new List<TimeSlot>();
        public frmChooseTimeslot(List<TimeSlot> fromTicketAssign) {
            InitializeComponent();
            //copy list
            _tsList = fromTicketAssign;
            _tsList.OrderBy(timeSlot => timeSlot.PrimaryKey);
        }
        private void frmChooseTimeslot_Load(object sender, EventArgs e) {
            int x = 1; //loop counter
            foreach (TimeSlot ts in _tsList) {
                //populate listbox with list entries
                string temp = "Time slot " + x.ToString() + ":\t" + ts.TimeSlotStart.ToString("t");
                lbTimeSlots.Items.Add(temp);

                x++;
            }
            lbTimeSlots.SelectedIndex = 0;
        }
        private void ButtonClick(object sender, EventArgs e) {
            if (sender == btnOK) {
                //send selected timeslot to frmTicketAssign
                this.Tag = _tsList[lbTimeSlots.SelectedIndex].TimeSlotStart;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (sender == btnCancel) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
