using System;

namespace Project_12_2 {
    public class Ticket {
        //ticket number: PK; _timeSlot: assigned time slot start
        private int _ticketNum;
        private DateTime _timeSlot;
        public Ticket(int t, DateTime timeSlot) {
            //Constructor - takes int (ticket number) and DateTime (assigned time slot)
            _ticketNum = t;
            _timeSlot = timeSlot;
        }
        public int TicketNumber {
            //get/set ticket number
            get { return _ticketNum; }
            set { _ticketNum = value; }
        }
        public DateTime AssignedTimeSlot {
            //get/set assigned time slot
            get { return _timeSlot; }
            set { _timeSlot = value; }
        }
        public int NextTicket() {
            //returns next ticket
            return _ticketNum + 1;
        }
    }
}
