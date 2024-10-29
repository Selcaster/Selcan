using System;
using System.Collections.Generic;

namespace meeting
{
    public class Meeting
    {
        private DateTime fromdate;
        public DateTime FromDate
        {
            get { return fromdate; }
            set { fromdate = value; }
        }

        private DateTime todate;
        public DateTime ToDate
        {
            get { return todate; }
            set { todate = value; }
        }

        private string fullname;
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public Meeting(DateTime FromDate, DateTime ToDate, string Fullname)
        {
            this.fullname = Fullname;
            this.fromdate = FromDate;
            this.todate = ToDate;
        }
    }

    public class ReservedDateIntervalException : Exception
    {
        public ReservedDateIntervalException(string message) : base(message)
        {
        }
    }

    public class WrongDateIntervalException : Exception
    {
        public WrongDateIntervalException(string message) : base(message)
        {
        }
    }

    public class MeetingSchedule
    {
        private Meeting[] Meetings = new Meeting[0]; 

        public void SetMeeting(DateTime fromDate, DateTime toDate, string fullName)
        {
            if (fromDate >= toDate)
            {
                throw new WrongDateIntervalException("Baslangic sondan evvel olur");
            }

            for (int i = 0; i < Meetings.Length; i++)
            {
                if ((fromDate < Meetings[i].ToDate && toDate > Meetings[i].FromDate) ||
                    (fromDate >= Meetings[i].FromDate && fromDate < Meetings[i].ToDate))
                {
                    throw new ReservedDateIntervalException("Rezerv olunub uje");
                }
            }

            Meeting newMeeting = new Meeting(fromDate, toDate, fullName);
            Array.Resize(ref Meetings, Meetings.Length + 1);
            Meetings[Meetings.Length - 1] = newMeeting;
        }

       public void DisplayMeetings()
        {
            foreach (var meeting in Meetings)
            {
                Console.WriteLine($"Meeting with {meeting.Fullname} from {meeting.FromDate} to {meeting.ToDate}");
            }
        }
    }
}
