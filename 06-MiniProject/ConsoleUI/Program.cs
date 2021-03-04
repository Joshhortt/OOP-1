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
            GetGuestInformation();

			PrintGuestInformation(); 

			Console.ReadLine();
        }

		private static void PrintGuestInformation()  
		{
			foreach (GuestModel guest in guests)
			{
				Console.WriteLine(guest.GuestInfo);
			}
		}

        public static void GetGuestInformation()
		{
			string moreGuestsArriving = "";

			do
			{
				GuestModel guest = new GuestModel
				{
					FirstName = GetInfoFromConsole("What is your first name: "),
					LastName = GetInfoFromConsole("What is your last name: "),
					MessageToHost = GetInfoFromConsole("What message would you like to say your host: ")
				};
				moreGuestsArriving = GetInfoFromConsole("Are more guests coming (yes/no): ");

				guests.Add(guest); 

				Console.Clear();

			} while (moreGuestsArriving.ToLower() == "yes");
		}
		private static string GetInfoFromConsole(string message)
		{
			Console.Write(message);
			string output = Console.ReadLine();

			return output;
		}
    }
 }






