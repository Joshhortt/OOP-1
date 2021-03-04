// Object Oriented Programming - part 1 - Class Libraries

using DemoLibrary.Models;
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
            PersonModel person = new PersonModel();  // right after typing PersonModel and we already added DemoLibrary as a Reference in ConsoleUI
                                                    // we still need to add 'using DemoLibrary manually or by doing 'PersonModel CTRL + DOT.
            Console.ReadLine();
        }
    }
}
