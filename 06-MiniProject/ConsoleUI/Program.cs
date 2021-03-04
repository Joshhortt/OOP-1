// Object Oriented Programming - part 1 - Mini-Project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture the information about each guest (assumtion is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
		private static List<GuestModel> guests = new List<GuestModel>();

		static void Main(string[] args)
        {
            //List<GuestModel> guests = new List<GuestModel>();  move outside of Main method so that 'guests' in Line 56 has access

            GetGuestInformation();

			foreach (GuestModel guest in guests)
			{
				Console.WriteLine(guest.GuestInfo);
			}

			Console.ReadLine();
        }

        // REFACTOR CODE

        public static void GetGuestInformation()
		{
			string moreGuestsArriving = "";

			do
			{
				GuestModel guest = new GuestModel();

				Console.WriteLine("What is your first name: ");
				guest.FirstName = Console.ReadLine();

				Console.WriteLine("What is your last name: ");
				guest.LastName = Console.ReadLine();

				Console.Write("What message would you like to say your host: ");
				guest.MessageToHost = Console.ReadLine();

				Console.Write("Are more guests coming (yes/no): ");
				moreGuestsArriving = Console.ReadLine();

				guests.Add(guest);  // Has access again when we move the instanciated List outside Main method

				Console.Clear();

			} while (moreGuestsArriving.ToLower() == "yes");
		}
    }
 }






