using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Program na powitanie");

            Console.Write("Podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

        }
    }
}
