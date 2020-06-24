using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            while (true)
            {
                Console.Write("Unesite broj: ");
                broj = int.Parse(Console.ReadLine());

                if (broj <= 1)
                {
                    Console.WriteLine("Broj mora biti veci od 1!");
                    //  continue;                                       //continue ga vraca nazad na pocetak sve dokle korisnik ne unese validan broj
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Izabrali ste {broj}.");

            while (broj! != 1)
            {
                if (broj % 2 == 0)
                {
                    broj /= 2;
                }
                else
                {
                    broj = broj * 3 + 1;
                }
                Console.WriteLine(broj);

            }
        }
    }
}
