using System;
namespace RegexPatternProblems
{
    class program
    {
        public static string instr = Console.ReadLine();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registation Problems");
            Pattern program = new Pattern();
            Console.WriteLine("-->Select to Program is Executed<--");
            Console.WriteLine("1.validate First Name : \n Exit");
            Console.WriteLine("Select Above Number:->");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(program.ValidateFirstName(instr));
                    break;
                    case 2:
                default:
                    Console.WriteLine("Please Select valid Number");
                    break;
            }
        }
    }
}
