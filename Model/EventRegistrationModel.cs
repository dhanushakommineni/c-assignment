using System;
using System.Collections.Generic;

namespace Neudesic.Events.Models
{
    public class EventRegistrationModel
    {
        public List<string> EventName { get; set; } = new List<string>();
        public List<string> EventType { get; set; } = new List<string>();
    }
}
