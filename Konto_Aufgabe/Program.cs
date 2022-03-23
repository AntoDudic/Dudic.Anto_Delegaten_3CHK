using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Konto_Aufgabe
{
    class Program
    {
        public delegate double CalculateKonto(double value1, double value2);
        static void Main(string[] args)
        {
            CalculateKonto calculate;
            var kontoStand1 = 0.0;
            var kontoStand2 = 0.0;
            var kontoStand3 = 0.0;

            double[] Konten = { kontoStand1, kontoStand2, kontoStand3 };

            do
            {
                Console.WriteLine("Bitte Konto Auswählen: Max(1), Sebbi(2), Anto(3)");
                var kontoidentifier = Console.ReadLine();
                Console.ReadKey();
                Console.WriteLine();

                if (kontoidentifier == "1")
                {
                    Console.WriteLine("Ihr Kontostand Beträgt " + Konten[0] + "$");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Wollen Sie Was Einzahlen (+) oder was Auszahlen (-)?");
                    string identifier = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Wie viel?");
                    var moneyCheck = double.TryParse(Console.ReadLine(), out double money);

                    Console.WriteLine();

                    if (identifier == "+" && moneyCheck)
                    {
                        calculate = Konto.Einnahme;
                    }
                    else if (identifier == "-" && moneyCheck)
                    {
                        calculate = Konto.Ausgabe;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine();
                        continue;
                    }

                    Konten[0] = calculate(Konten[0], money);

                    if (identifier == "+")
                    {
                        Console.WriteLine("Es wurden " + money + "$ Ihrem Konto Hinzugefügt!");
                    }
                    else
                    {
                        Console.WriteLine("Es wurden " + money + "$ aus Ihrem Konto Entnommen!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Escape - Program ende");
                    Console.WriteLine();
                }
                else if (kontoidentifier == "2")
                {
                    Console.WriteLine("Ihr Kontostand Beträgt " + Konten[1] + "$");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Wollen Sie Was Einzahlen (+) oder was Auszahlen (-)?");
                    string identifier = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Wie viel?");
                    var moneyCheck = double.TryParse(Console.ReadLine(), out double money);

                    Console.WriteLine();

                    if (identifier == "+" && moneyCheck)
                    {
                        calculate = Konto.Einnahme;
                    }
                    else if (identifier == "-" && moneyCheck)
                    {
                        calculate = Konto.Ausgabe;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine();
                        continue;
                    }

                    Konten[1] = calculate(Konten[1], money);

                    if (identifier == "+")
                    {
                        Console.WriteLine("Es wurden " + money + "$ Ihrem Konto Hinzugefügt!");
                    }
                    else
                    {
                        Console.WriteLine("Es wurden " + money + "$ aus Ihrem Konto Entnommen!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Escape - Program ende");
                    Console.WriteLine();
                }
                else if (kontoidentifier == "3")
                {
                    Console.WriteLine("Ihr Kontostand Beträgt " + Konten[2] + "$");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Wollen Sie Was Einzahlen (+) oder was Auszahlen (-)?");
                    string identifier = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Wie viel?");
                    var moneyCheck = double.TryParse(Console.ReadLine(), out double money);

                    Console.WriteLine();

                    if (identifier == "+" && moneyCheck)
                    {
                        calculate = Konto.Einnahme;
                    }
                    else if (identifier == "-" && moneyCheck)
                    {
                        calculate = Konto.Ausgabe;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine();
                        continue;
                    }

                    Konten[2] = calculate(kontoStand3, money);

                    if (identifier == "+")
                    {
                        Console.WriteLine("Es wurden " + money + "$ Ihrem Konto Hinzugefügt!");
                    }
                    else
                    {
                        Console.WriteLine("Es wurden " + money + "$ aus Ihrem Konto Entnommen!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Escape - Program ende");
                    Console.WriteLine();
                }

                

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
    class Konto
    {
        public static double Einnahme(double x, double y)
        {
            return x + y;

        }

        public static double Ausgabe(double x, double y)
        {
            return x - y; 
        }
    }
}
