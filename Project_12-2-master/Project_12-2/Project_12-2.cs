using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
/*******************************************************************************
|                                 PROJECT 12-2                                 |
|                              By: Richard Anesi                               |
|------------------------------------------------------------------------------|
|                                                                              |
*******************************************************************************/
namespace Project_12_2 {
    public partial class frmTicketAssign : Form {

        ////////////////////////////////////////////////////////////////////////////////
        //      Class-scope variables
        ////////////////////////////////////////////////////////////////////////////////

        //Fields!

        private int ticketNumber;
        DateTime windowStart, 
            startTime, 
            endTime;
        TimeSlot selectedSlot;

        //Containers!

        List<TimeSlot> slotList = new List<TimeSlot>();
        List<Ticket> ticketList = new List<Ticket>();

        public frmTicketAssign() { InitializeComponent(); }

        ////////////////////////////////////////////////////////////////////////////////
        //      Methods
        ////////////////////////////////////////////////////////////////////////////////

        private void SetFormText() {

            //Instantiating new DateTime object to retrieve current time from the system

            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            //String time = current local system time

            string time;
            time = currentTime.ToString("t");

            //Determine whether time is within business hours

            if (DateTime.Now >= startTime && DateTime.Now <= endTime)
                time += " (Open)";
            else
                time += " (Closed)";

            //displays current time slot (could probably be inferred)    
                                          
            time += " Current Timeslot: " + selectedSlot.TimeSlotStart.ToString("t");
            this.Text = time;    
        }
        private void SetOptions() {

            //string array to store tag

            string[] temp = new string[5];

            //start new dialog using frmOptions

            Form options = new frmOptions();
            DialogResult btnOK = options.ShowDialog();

            if (btnOK == DialogResult.OK) {

                int minutesPerWindow, 
                    guestsPerWindow;

                //split string retrieved form options form

                temp = options.Tag.ToString().Split('|');

                //Number of minutes per timeslot

                minutesPerWindow = Convert.ToInt32(temp[0]);

                //Number of guests per timeslot

                guestsPerWindow = Convert.ToInt32(temp[1]);

                //Business opening time

                startTime = Validator.RemoveSeconds(Convert.ToDateTime(temp[2]));

                //Business closing time

                endTime = Validator.RemoveSeconds(Convert.ToDateTime(temp[3]));

                //Number of first ticket

                ticketNumber = Convert.ToInt32(temp[4]);
                
                //Clear class-scope lists to assign new settings

                ticketList.Clear();
                lbTickets.Items.Clear();
                slotList.Clear();

                //Difference between ending and starting times

                TimeSpan s = endTime.Subtract(startTime);

                //Number of minutes = total minutes per day / number of minutes in each time window

                int slotsNumber = Convert.ToInt32(Math.Round(s.TotalMinutes)) / minutesPerWindow;

                //Fill each timeslot with an instantiated timeslot object

                for (int x = 0; x < slotsNumber; x++)
                    slotList.Add(
                        new TimeSlot(guestsPerWindow, 
                        startTime + TimeSpan.FromMinutes(minutesPerWindow * x), 
                        new TimeSpan(0, minutesPerWindow, 0)));

                //Order slotList by primary key value

                slotList.OrderBy(timeslot => timeslot.PrimaryKey);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        //      EVENTS
        ////////////////////////////////////////////////////////////////////////////////

        private void FormLoad(object sender, EventArgs e) {

            //disable timer to avoid throwing an exception

            timer.Enabled = false;

            //start time = current local time minus seconds and milliseconds (for ease of comparison)

            windowStart = Validator.RemoveSeconds(DateTime.Now);

            //launch options form to set initial settings

            SetOptions();

            //copy first timeslot to selectedSlot

            selectedSlot = (TimeSlot)slotList[0].Clone();

            //set the initial form text

            SetFormText();

            //reenable the timer

            timer.Enabled = true;
        }      
        private void ButtonClicked(object sender, EventArgs e) {

            ////////////////////////////////////////////////////////////////////////////////
            //      btnIssueTicket
            ////////////////////////////////////////////////////////////////////////////////

            if (sender == btnIssueTicket) {

                if (selectedSlot.TicketsAssigned < selectedSlot.TicketsNumber && 
                    DateTime.Now > startTime 
                    && DateTime.Now < endTime) {

                    if (selectedSlot.TimeSlotStart >= DateTime.Now) {

                        //add ticket object to ticket list box using the current ticket number and the selected slot timeslot

                        ticketList.Add(new Ticket(ticketNumber, selectedSlot.TimeSlotStart));

                        //create string using information from last ticket object

                        string temp = string.Format("Ticket #{0} : {1:t}",
                            ticketList[ticketList.Count - 1].TicketNumber, ticketList[ticketList.Count - 1].AssignedTimeSlot);

                        foreach (TimeSlot ts in slotList)

                            //Compares each timeslot to timeslot current time, sets fields in TS object where
                            //TS.Time == currentTime.Time; then clones TS to CT (tracks # of tickets)

                            if (ts.TimeSlotStart.Minute == selectedSlot.TimeSlotStart.Minute &&
                                ts.TimeSlotStart.Hour == selectedSlot.TimeSlotStart.Hour) {

                                ts.AddTicket();
                                selectedSlot = (TimeSlot)ts.Clone();
                            }

                        //add temp string to tickets list box, sort ticket list by ticket list (identifier)

                        lbTickets.Items.Add(temp);

                        //sets ticket number to ticket number returned from last ticket's NextTicket method

                        ticketNumber = ticketList[ticketList.Count - 1].NextTicket();
                    }
                    else
                        Validator.Error("cannot assign tickets to expired time slot", "Invalid Time Selection");
                }
                else if (DateTime.Now < startTime || DateTime.Now > endTime)
                    Validator.Error("outside of business hours");
                else
                    Validator.Error("number of guests per timeframe exceeded", "Too Many Cooks");
            }

            ////////////////////////////////////////////////////////////////////////////////
            //      btnChooseTS
            ////////////////////////////////////////////////////////////////////////////////

            else if (sender == btnChooseTS) {

                //Launch frmChooseTimeslot, get tag, assign current slot to matching time slot

                Form chooseTimeSlot = new frmChooseTimeslot(slotList);
                DialogResult btnOK = chooseTimeSlot.ShowDialog();

                if (btnOK == DialogResult.OK) {

                    DateTime temp = Convert.ToDateTime(chooseTimeSlot.Tag.ToString());

                    foreach (TimeSlot ts in slotList)
                        if (temp.Hour == ts.TimeSlotStart.Hour & 
                            temp.Minute == ts.TimeSlotStart.Minute)
                            selectedSlot = (TimeSlot)ts.Clone();
                }
            }

            ////////////////////////////////////////////////////////////////////////////////
            //      btnOptions
            ////////////////////////////////////////////////////////////////////////////////

            else if (sender == btnOptions) {

                //Show options IF DialogResult is OK

                string  m1 = "Warning! This will overwrite any current settings. Continue?",
                        m2 = "Warning";
                if (MessageBox.Show(m1, m2, MessageBoxButtons.OKCancel) == DialogResult.OK)
                    SetOptions();
            }

            ////////////////////////////////////////////////////////////////////////////////
            //      btnExit
            ////////////////////////////////////////////////////////////////////////////////

            else if (sender == btnExit) {

                //Closes the program

                if (MessageBox.Show("Do you wish to exit the program?", "Program Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }   
        }
        private void TimerTick(object sender, EventArgs e) {

            //temporary string variables used by the labels' text properties

            string t1 = "", t2 = "";

            //Update form text to reflect current information

            SetFormText();
            
            if (ticketList.Count > 0) {
                foreach (Ticket t in ticketList) {

                    //Determines whether a ticket's window has elapsed, removes it from listbox/ticket list

                    if (t.AssignedTimeSlot.Hour <= DateTime.Now.Hour &
                        t.AssignedTimeSlot.Minute + selectedSlot.SlotDuration.Minutes <= DateTime.Now.Minute) {

                        lbTickets.Items.RemoveAt(ticketList.IndexOf(t));

                        ticketList.RemoveAt(ticketList.IndexOf(t));

                        ticketList.OrderBy(ticket => ticket.TicketNumber);

                        //break necessary to avoid thrown exception (modified enumeration)
                        break;
                    }
                    else if (t.AssignedTimeSlot + selectedSlot.SlotDuration >= DateTime.Now &
                        t.AssignedTimeSlot + selectedSlot.SlotDuration <= DateTime.Now + selectedSlot.SlotDuration) {

                        //determines whether a ticket number fits within a defined window of time

                        if (ticketList.IndexOf(t) != ticketList.Count - 1)
                            t2 += t.TicketNumber.ToString() + ", ";

                        else
                            t2 += t.TicketNumber.ToString();
                    }
                }
            }

            //Sets next available timeslot based on slot list

            foreach (TimeSlot ts in slotList)
                if (ts.TimeSlotStart > DateTime.Now) {
                    t1 = (ts.TimeSlotStart).ToString("t");
                    break;
                }

            //Set label text properties to appropriate values

            lblGuests.Text = t2; 

            lblTicketsOutstanding.Text = ticketList.Count.ToString();

            lblNextEntry.Text = t1;
        }
    }
}