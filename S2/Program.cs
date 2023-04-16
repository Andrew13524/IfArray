using System;

namespace S2
{
    class Program
    {
        static void Main(string[] args)
        {
            //                              0         1
            string[] names = new string[] { "Andrew", "Douglas" };
            Console.WriteLine(names[2]);

            string[] array = new string[2];

            Console.WriteLine("Enter a number: ");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("input was 1");
            }
            else if (input == 2)
            {
                Console.WriteLine("input was 2");
            }
            else if (input == 3)
            {
                Console.WriteLine("input was 3");
            }
            else
            {
                Console.WriteLine("input was " + input);
            }
        }
    }
}
