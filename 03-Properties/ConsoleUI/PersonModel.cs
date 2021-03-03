using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		//public int Age { get; set; }

//******************************** Why and when use full properties *******************************

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
		// public string SSN { get; set; }  // social security number 123-45-6789

		private string _ssn;

		public string SSN
		{
			get 
			{   // 123-45-6789  (11 - 4 = 7)
				string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);  // Shows only the last 4 digits
				return output;
			}
			set 
			{ 
				_ssn = value; 
			}
		}
	}
}
