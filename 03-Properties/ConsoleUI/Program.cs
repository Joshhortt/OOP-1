// Object Oriented Programming - part 1 - Properties
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Horta");  // Passing in the last name to the constructor
            person.FirstName = "Jose";
            //person.LastName = "Horta";
            person.Age = 39;
            person.SSN = "987-45-1236";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadLine();
        }
    }
}
