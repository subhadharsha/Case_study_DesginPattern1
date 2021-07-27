using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesginPattern_II
{
    public interface IObserver
    {
        void update(Events popularEvent);
    }
    interface IEvents
    {
        public int TicketsBooked { get; set; }

        public string EventName { get; set; }
    }
}
