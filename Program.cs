using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
         {
            double a, b, pole;
            Console.WriteLine("Program oblicza pole prostokąta. ");

            Console.WriteLine("Podaj dlugość boku a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b: ");
            b = double.Parse(Console.ReadLine());

            pole = a * b;

            Console.Write("Pole prostokąta o boku a={0} i boku b={1} ",a,b);
            Console.Write("Wynosi {0}", pole);

            Console.Read(); //Zamyka Cmd po naciśnieciu Entera




        }
    }
}
