using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esto es c#");
            int a, b, c; // declaración variables
            a =Convert.ToInt32(Console.ReadLine()); //Recibir el valor del teclado
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                //este lado es el valor del si
                if (b > c)
                {
                    Console.WriteLine("a,b,c");
                }
                else
                {
                    //Este es el lado del no
                    if (a > c)
                    {
                        Console.WriteLine("a,c,b");
                    }
                    else
                    {
                        Console.WriteLine("c,a,b");
                    }
                }
            }
            else
            {

            }
        }
    }
}
