using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternProblems
{
    public class Pattern
    {
        //Create a pattern for a first name thats start with cap and has min 3 char (UC1)
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";//Minimum 3 Char.

        //Method for Validate First Name using regex(UC1)
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, FIRST_NAME_REGEX);

        }
        //Create a pattern for a last name thats start with cap and has min 3 char (UC2)
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";//Minimum 3 Char.
        
        //Method for validate Last Name using regex (UC2)
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);
        }
    }
}
