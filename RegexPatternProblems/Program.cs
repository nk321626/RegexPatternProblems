using System;
namespace RegexPatternProblems
{
    class program
    {
        //Takes an input from the user.
        private static readonly string instr = Console.ReadLine();
        //Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registation Problems");
            Pattern program = new Pattern();
            Console.WriteLine("-->Select to Program is Executed<--");
            Console.WriteLine("1.Validate First Name : \n2. validate Last Name:\n3. Exit");
            Console.WriteLine("Select Above Number:->");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(program.validateFirstName(instr)); //Print the output
                    break;
                case 2:
                    Console.WriteLine(program.validateLastName(instr)); //Print the output
                    break;
                case 3:
                default:
                    Console.WriteLine("Please Select valid Number");
                    break;
            }
        }
    }
}
