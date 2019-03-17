using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolityczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            Console.WriteLine($"Witaj {imie} !!!!");
        }
    }
}
