using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;int avansare = 1;int luna = 0;
            float an = 0;
            Console.WriteLine("Introduceti viteza puterii de calcul");
                n =
                int.Parse(Console.ReadLine());
            while (n >= avansare) 
            { avansare = avansare * 2;
                luna = luna + 18;
            }
            Console.WriteLine($"Viteza puterii de calcul {n} va fi pbtinuta in {luna} luni");
            Console.WriteLine( $"Aproximativ in {an = (float)luna / 12 } ani");
            Console.ReadKey();
        }
    }
}
