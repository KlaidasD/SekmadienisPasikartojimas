using System;

namespace Sekmadienis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pradedama pirma uzduotis..");
            pirma();
            Console.WriteLine("Pradedama antra uzduotis..");
            antra();
            Console.WriteLine("Pradedama trecia uzduotis..");
            trecia();
            Console.WriteLine("Visos uzduotys buvo parodytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");


            void pirma()
            {
                /*Sugeneruokite 300 atsitiktinių skaičių nuo 0 iki 300, atspausdinkite juos atskirtus tarpais ir suskaičiuokite kiek tarp jų yra didesnių už 150.  Skaičiai didesni nei 275 turi būti atspausdinti skliausteliuose” [ ]*/

                int[] skaiciai = new int[300];
                Random rnd = new Random();
                int didesni = 0;

                Console.WriteLine($"Sugeneruojami 300 atsitiktiniu skaiciu...");
                
                for(int i = 0; i < skaiciai.Length; i++)
                {
                    skaiciai[i] = rnd.Next(0, 301);
                    Console.Write(skaiciai[i] + " ");
                    if (skaiciai[i] > 150)
                    {
                        didesni++;
                    }
                    if (skaiciai[i] > 275)
                    {
                        Console.Write($"[{skaiciai[i]}]");
                    }
                
                }

                Console.WriteLine($"\nViso didesniu skaiciu, nei 150 = {didesni}");

            }

            void antra()
            {

                /*Vienoje eilutėje atspausdinkite visus skaičius nuo 1 iki 3000, kurie dalijasi iš 77 be liekanos. Skaičius atskirkite kableliais. Po paskutinio skaičiaus kablelio neturi būti.*/

                int iki = 3000;

                for (int i = 1; i < iki; i++)
                {
                    if (i % 77 == 0)
                    {
                        Console.Write(i);

                        if (i + 77 <= iki)
                            Console.Write(",");
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }

                Console.WriteLine();
            }

            void trecia()
            {

                /*Nupieškite kvadratą iš “*”, kurio kraštines sudaro 25“*”*/

                string x = "* ";
                string xt = "*-----------------------------------------------*";
                for(int i = 0;i < 25;i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();

                for(int i = 0;i < 23;i++)
                {
                    Console.WriteLine(xt);
                }

                for (int i = 0; i < 25; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();


            }



        }


    }
}

