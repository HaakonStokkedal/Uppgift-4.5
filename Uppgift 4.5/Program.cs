using System;

namespace Uppgift_4._5
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string tal = Console.ReadLine();

            for (int i = 0; i < tal.Length; i++)
            {
                string tecken = tal[i].ToString();
                int siffra = int.Parse(tecken);
                if(siffra == 9)
                {
                    Console.Write(0);
                }
                else
                {
                    Console.Write(siffra + 1);
                }
            }
            Console.ReadKey();
        }
    }
}