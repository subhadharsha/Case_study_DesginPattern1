using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_DesginPattern_II
{
    public class NotificationService
    {
        public List<IObserver> observers = new List<IObserver>();
        Events danceEvent = new Events("dance", 0);
        Events musicEvent = new Events("music", 0);
        Events photographyEvent = new Events("photography", 0);

        public void Subscribe(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void ChangeState(int bookedTicktes, string eventName)
        {
            if(eventName=="dance")
            {
                danceEvent.notification = this;
                danceEvent.TicketsBooked = bookedTicktes;
            }
            else if(eventName=="music")
            {
                musicEvent.notification = this;
                musicEvent.TicketsBooked = bookedTicktes;                
            }
            else
            {
                photographyEvent.notification = this;
                photographyEvent.TicketsBooked = bookedTicktes;
            }
            
        }

       /* public  void notifyUpdate(Events m)
        {
            foreach (var o in observers)
            {
                o.update(m);
            }
            Console.WriteLine();
        }*/
    }
}
