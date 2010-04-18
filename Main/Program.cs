using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klase;
namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            while (true)
            {
                Console.WriteLine("Unesi prvi broj:");
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Morate uneti broj");
                }

            }
            while (true)
            {
                Console.WriteLine("Unesi drugi broj:");
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Morate uneti broj");
                }
            }
            Operacije s = Operacije.sabiranje(a, b);
            Operacije o = Operacije.oduzimanje(a, b);
            Operacije m = Operacije.mnozenje(a, b);
            Operacije d = Operacije.deljenje(a, b);
            Console.WriteLine("Zbir: {0}", s.racunaj());
            Console.WriteLine("Razlika: {0}", o.racunaj());
            Console.WriteLine("Proizvod: {0}", m.racunaj());
            Console.WriteLine("Kolicnik: {0}", d.racunaj());
        }
    }
}
