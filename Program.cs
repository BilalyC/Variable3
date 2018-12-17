using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Veuillez saisir une valeur pour a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir une valeur pour b : ");
            b = int.Parse(Console.ReadLine());

            a = a + 33;
            b++;

            Console.WriteLine(a + "/" + b + " = " + (a/b));
        }
    }
}
