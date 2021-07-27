using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesginPattern_II
{
    public class Events:IEvents
    {
        public NotificationService notification { get; set; }
        
        private int ticketsBooked;
        //public int TicketsBooked { get; set; }
        public int TicketsBooked
        {
            get
            {
                return ticketsBooked;
            }
            set
            {
                ticketsBooked = value;
                if (value >= 100)
                {
                    notifyUpdate(this);
                }
            }
        }
        public void notifyUpdate(Events m)
        {
            foreach (var o in notification.observers)
            {
                o.update(m);
            }
            Console.WriteLine();
        }
        public string EventName { get; set; }

        public Events(string eventName, int ticketsBooked )
        {
            TicketsBooked = ticketsBooked;
            EventName = eventName;
        }
    }
}
