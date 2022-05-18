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
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";//Minimum 3 Char.

        //Method for Validate First Name.
        public bool ValidateFirstName(string fname)
        {
            return Regex.IsMatch(fname, FIRST_NAME_REGEX);

        }
    }
}
