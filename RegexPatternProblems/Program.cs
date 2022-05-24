using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RegexPatternProblems
{
    class program
    {
        static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome to User Registation Problems");
            RegexPattern pattern = new RegexPattern(); //Creating Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Enter Your Emali Id \n\t4.Enter Your Mobile Number \n\t5.Enter Your Passwrd \n\t6.Exit");
                Console.Write("\tEnter Numbers: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Validating user entered a valid firstname or not(UC1)
                        Console.Write("\tEnter Your First Name: ");
                        pattern.CheckFirstName();//Call the Method.
                        break;
                    case 2:
                        //Validating user entered a valid Lastname or not(UC2)
                        Console.Write("\tEnter Your Last Name: ");
                        pattern.CheckLastName();//Call the Method.
                        break;
                    case 3:
                        //Validating user entered a valid Email id or not(UC3)
                        Console.Write("\tEnter Your Email Id: ");
                        pattern.CheckEmail();//Call the Method.
                        break;
                    case 4:
                        //Validating user entered a valid Mobile Numbers or not(UC4)
                        Console.Write("\tEnter Your Mobile Numbers: ");
                        pattern.CheckMobileNumber();//Call the Method.
                        break;
                    case 5:
                        //Validating user entered a valid Passwrd or not (UC5 UC6 UC7 & UC8)
                        Console.WriteLine("\tEnter Your Passwrd: ");
                        pattern.CheckPasswrd(); //Call the Method.
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\tSelect Correct Number");
                        break;
                }   
            }
        }
    }
}
