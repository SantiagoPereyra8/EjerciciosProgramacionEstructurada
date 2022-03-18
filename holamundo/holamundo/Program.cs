using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holamundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, to, p;
            Console.WriteLine("Primer Numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo Numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tercer Numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuarto Numero: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quinto numero: ");
            n5 = Convert.ToInt32(Console.ReadLine());

            to = n1 + n2 + n3 + n4 + n5;
            p = to/5;
            Console.WriteLine("Total de todos los numeros {0}", to);
            Console.WriteLine("Promedio total {0}", p);
            Console.ReadKey();

            



        }
    }
}
