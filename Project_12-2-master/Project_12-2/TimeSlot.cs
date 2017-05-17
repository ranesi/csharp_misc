using System;

namespace Project_12_2 {
    public class TimeSlot : ICloneable {
        /// <summary>
        /// Timeslot object, includes slot start, duration, number of tickets per timeslot, number of assigned tickets
        /// </summary>

        //Fields: 
        //primary key (used for sorting purposes - compound of hour + minute)
        //maximum tickets: the number of allowed tickets per time slot
        //number of tickets: tickets currently "used"
        //start of time slot
        //timeslot duration                   
        private int _primaryKey, 
            _maxTickets,
            _numTickets;
        private DateTime _tsStart;
        private TimeSpan _tsDuration;
        public TimeSlot() { }
        public TimeSlot(int ticketNumber, DateTime start, TimeSpan duration) {
            //Constructor
            //TicketsNumber, TimeSlotStart, and TimeSlotDuration are assigned to fields
            //The number of assigned tickets always initializes to 0
            //the primary key is formed from a concatenation of hours and minutes (i.e. 1015, 1535, 2220)
            _maxTickets = ticketNumber;
            _numTickets = 0;
            _tsStart = start;
            _tsDuration = duration;
            _primaryKey = Convert.ToInt32(_tsStart.Hour.ToString() + _tsStart.Minute.ToString());
        }
        public int PrimaryKey {
            //return primary key
            get { return _primaryKey; }
        }
        public int TicketsNumber {
            //get/set the maximum number of tickets allowed
            get { return _maxTickets; }
            set { _maxTickets = value;}
        }
        public int TicketsAssigned {
            //get/set number of tickets used
            get { return _numTickets; }
            set { _numTickets = value; }
        }
        public DateTime TimeSlotStart {
            //time specified as start time for time slot
            get { return _tsStart; }
            set { _tsStart = value; }
        }
        public TimeSpan SlotDuration {
            //get/set duration of timeslot
            get { return _tsDuration; }
            set { _tsDuration = value; }
        }
        public DateTime TimeSlotEnd {
            //returns end of time slot
            get { return _tsStart + _tsDuration; }
        }
        public void AddTicket() => _numTickets+=1;
        public object Clone() {
            //clones the timeslot;
            //nomenclature: (TimeSlot)object.Clone();
            return this.MemberwiseClone();
        }
    }
}
