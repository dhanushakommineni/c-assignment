using System;
using System.Collections.Generic;
using System.Text;

namespace Neudesic.Events.Models
{
    class EventsCatalog
    {
        public void Display(EventRegistration eventDetailsObject)
        {
            int limit = eventDetailsObject.EventName.Count;
            Console.WriteLine("Event Name\tEventType");
            for (int index = 0; index < limit; index++)
            {
                Console.WriteLine(eventDetailsObject.EventName[index] + "\t" + eventDetailsObject.EventType[index]);
            }
        }
    }
}
