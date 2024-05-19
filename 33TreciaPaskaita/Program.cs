/*Sukurkite funkciją kuriai paduodame du double skaicius bei matematinio veiksmo (+,-/,*) operatorių kaip string ir pagal tą operatorių funkcija atlika veiksmą ir grąžina rezultatą*/

using System;

namespace Sekmadienis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            matVeiksmas(rnd.Next(1, 100), rnd.Next(1, 100), "*");


            void matVeiksmas(double a, double b, string c)

            {
                double veiksmas = 0;

                switch (c)
                {
                    case "+":
                        veiksmas = a + b;
                        break;
                    case "-":
                        veiksmas = a - b;
                        break;
                    case "/":
                        veiksmas = a / b;
                        break;
                    case "*":
                        veiksmas = a * b;
                        break;
                }

                Console.WriteLine($"Siu kintamuju {a} {c} {b} rezultatas yra: {veiksmas}");






            }
        }
    }
}

