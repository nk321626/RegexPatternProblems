using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternProblems
{
    public class RegexPattern
    {
        //Method to check and take the first name using regex(UC1)
        public void CheckFirstName()
        {

            string firstName = Console.ReadLine();
            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, fNamePattern))
            {
                Console.WriteLine("\tThe entered first name is valid");
            }
            else
            {
                Console.WriteLine("\tFirst name should starts with Cap and should have minimum 3 characters");
            }
        }

        //Method to check and take the last name using regex(UC2)
        public void CheckLastName()
        {
            string lastName = Console.ReadLine();
            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
            string lNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lastName, lNamePattern))
            {
                Console.WriteLine("\tThe given last name is valid");
            }
            else
            {
                Console.WriteLine("\tLast name should starts with Cap and should have minimum 3 characters");
            }
        }
    }
}