// Object Oriented Programming - part 1 - Namespaces
using System;
using System.Collections.Generic;
using ConsoleUI.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();  // List Instance
            Console.WriteLine();

            PersonModel person = new PersonModel(); // person Instance

            Calculations.Add(4, 3);

            Console.ReadLine();
        }
    }
}
