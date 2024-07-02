using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 53;

            // TODO: The switch statement
            switch (theVal)
            {
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("theVal is 51");
                    break;
                default:
                    Console.WriteLine("theVal is something else");
                    break;
            }
        }
    }
}
