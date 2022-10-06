using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Calculator");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("CALCULATOR");

            double nr1 = 0;
            double nr2 = 0;
            double result = 0;

            Console.WriteLine("< NR 1 >");
            nr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("< NR 2 >");
            nr2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n< ALEGE O OPERATIE >");
            Console.WriteLine("Adunare (+)\tScadere (-)\nInmultire (x)\tImpartire (/)");

            switch (Console.ReadLine())
            {
                case "+":
                    result = nr1 + nr2;
                    Console.WriteLine("< REZULTAT ADUNARE >\n" + result);
                    break;
                case "-":
                    result = nr1 - nr2;
                    Console.WriteLine("< REZULTAT SCADERE >\n" + result);
                    break;
                case "x":
                    result = nr1 * nr2;
                    Console.WriteLine("< REZULTAT INMULTIRE >\n" + result);
                    break;
                case "/":
                    result = nr1 / nr2;
                    Console.WriteLine("< REZULTAT IMPARTIRE >\n" + result);
                    break;
            }

            Console.ReadLine();
        }
    }
}
