using System;

namespace inluppg4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj ett av följande alternativ:\n1. Subtrahera två tal\n2. Dividera ett tal med ett annat\n3. Avsluta programmet");
                int menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection == 1)
                {
                    Console.WriteLine("Skriv första talet");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv första talet");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Svaret blir: " + (num1 - num2) + "\n\n\n\n");
                }
                else if (menuSelection == 2)
                { 
                    Console.WriteLine("Skriv första talet");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv första talet");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Svaret blir: " + (num1 / num2) + "\n\n\n\n");
                }
                else if ( menuSelection == 3)
                {
                    return;
                }
            }
        }
    }
}