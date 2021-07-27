using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesginPattern_II
{
    

    public class Admin : IObserver
    {
        public void update(Events popularEvent)
        {
            Console.WriteLine("Popular Event is :"+ popularEvent.EventName +
                              "\nBooked tickets :"+ popularEvent.TicketsBooked  );
        }
    }
}
