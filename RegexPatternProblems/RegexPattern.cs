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
        //Method to check and take the valid email using regex(UC3)
        public void CheckEmail()
        {
            string emailId = Console.ReadLine();
            //Pattern for checking the email id(UC3)
            string emailIdPattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(emailId, emailIdPattern))
            {
                Console.WriteLine("\tThe given email id is valid");
            }
            else
            {
                Console.WriteLine("\tThe given email id is not valid");
            }
        }
        //Method to check and take the valid mobile number using regex(UC4)
        public void CheckMobileNumber()
        {
            string mobileNum = Console.ReadLine();
            //Pattern for checking the mobile number(UC4)
            string mobNumPattern = "^91[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNum, mobNumPattern))
            {
                Console.WriteLine("\tThe given mobile number is valid");
            }
            else
            {
                Console.WriteLine("\tThe number should follow 91 10 digits E.g. 91 9919819801");
            }
        }
    }
}