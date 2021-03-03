using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
		public int FirstName { get; set; }
		public string LastName { get; set; }
		//public int Age { get; set; }


	//  the code below is the equivalent as the commented line property of 'Age'.
		private int _age; // private backing field of creating variables (underscore + camelCase)

			public int Age
		{
			get 
			{
				return _age; 
			}
			set 
			{ 
				if(value >= 0 && value < 126)
				{
					_age = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException("value, Age needs to be in a valid range. ");
				}
			}
		}

	}
}
