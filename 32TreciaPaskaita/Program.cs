/* * Užduotis
Tema: Studentų pažymių analizė

Užduotis: Parašykite C# programą, kuri atliktų šiuos veiksmus:

Sukurtų masyvą iš n studentų pažymių (atsitiktinių skaičių intervale nuo 1 iki 10).
Naudotų ciklus, kad:
Atspausdintų visus pažymius.
Apskaičiuotų ir atspausdintų pažymių vidurkį.
Apskaičiuotų ir atspausdintų didžiausią ir mažiausią pažymį.
Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų teigiamų pažymių skaičių.
Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų pažymių sumą.

Teigiamas skaitosi 5 ir daugiau

 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Sekmadienis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[50];
            Random rnd = new Random();

            for(int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 10);
                Console.Write($"{n[i]} ");
            }

            int suma = 0;

            for(int i = 0; i < n.Length;i++)
            {
                suma += n[i];
            }

            double vidurkis = (double)suma / n.Length;

            int max = n[0];
            int min = n[0];

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
                else if (n[i] < min)
                {
                    min = n[i];                
                }
            }

            Console.WriteLine($"\nDidziausias pazymys {max} ir maziausias pazymys {min}");

            grTeig(n);
            grSuma(n);

            void grTeig(int[] n)
            {

                int suma = 0;
                int kiekis = 0;

                Console.WriteLine("Spausdinami teigiami pazymiai..");
                

                for(int i = 0;i < n.Length;i++)
                {
                    if (n[i] >= 5)
                    {
                        Console.Write($"{n[i]} ");
                        suma ++;
                    }
                    
                }

                Console.WriteLine($"\nTeigiamu pazymiu skaicius:{suma}");
            }

            void grSuma(int[] n)
            {
                int suma = 0;

                Console.WriteLine("Apskaiciuojama ir spausdinama visu pazymiu suma...");

                for(int i = 0;i < n.Length;i++)
                {
                    suma += n[i];
                }

                Console.WriteLine($"Visu pazymiu suma:{suma}");


            }

        }
    }
}

