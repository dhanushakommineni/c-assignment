using System;
using System.Collections.Generic;
using System.Text;

namespace Neudesic.Events.Models
{
    class EventRegistration
    {
        public void AddDetails()
        {
            Console.WriteLine("enter event name");
            EventName.Add(Console.ReadLine());
            Console.WriteLine("enter event type");
            EventType.Add(Console.ReadLine());
        }
    }
}
