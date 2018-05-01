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
            Console.WriteLine(" ");

            //Program który ma wyświetlać liczbę pi w CMD 

                Console.WriteLine("Wyświetlamy liczbę pi");

                    double pi = 3.1416;
                    Console.WriteLine(pi);
                    Console.WriteLine("");

            //Program obliczajacy objętość kuli

            double r, objetosc;
            Console.WriteLine("Oblicz objetość kuli o promieniu r ");
            Console.WriteLine("Podaj długość promienia r. ");
            r = double.Parse(Console.ReadLine());
            objetosc = 4.0 * 3.14 * r * r * r / 4;
            Console.WriteLine("Objetość kuli o promieniu r= {0:#.##} wynosi {1:#.##} ", r, objetosc);
            Console.WriteLine(" ");

            //Dzielenie dwóch liczb całkowitych bez reszy

            int i = 37; int j = 11;
            Console.WriteLine("Dzielenie dwoch liczb calkowitych bez reszty");
            Console.WriteLine("Dla liczby a= " + i + " liczby b = " + j);
            Console.WriteLine("Iloraz z " + i + "/" + j + "Wynosi: " + i / j);



         Console.Read(); //Zamyka Cmd po naciśnieciu Entera




        }
    }
}
