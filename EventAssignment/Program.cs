using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Events.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string check = "yes";
            EventRegistration eventDetailsObject = new EventRegistration();
            EventsCatalog showDetailsObject = new EventsCatalog();
            do
            {
                Console.WriteLine("do you want to add event press 1:add event,To show event Details press 2:show events");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        eventDetailsObject.AddDetails();
                        break;
                    case 2:
                        Console.WriteLine("event details");
                        showDetailsObject.Display(eventDetailsObject);
                        break;
                }
                Console.WriteLine("enter yes to continue");
                check = Console.ReadLine();
            } while (check == "yes");
        }
    }
}