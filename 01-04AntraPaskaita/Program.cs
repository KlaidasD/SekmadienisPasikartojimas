/*1. Užduotis: Skaičių sekos suma
Parašykite programą, kuri naudoja while ciklą, kad suskaičiuotų visų teigiamų skaičių, mažesnių nei nurodytas skaičius 𝑛
n, suma. Programa turi paprašyti vartotojo įvesti skaičių 𝑛
n ir tada išvesti suskaičiuotą sumą.


2. Užduotis: Atvirkštinis skaičių išvedimas
Parašykite programą naudojant for ciklą, kuri paprašo vartotojo įvesti skaičių 𝑛
n ir tada išveda visus skaičius nuo 𝑛
n iki 1 atvirkštine tvarka. Kiekvienas skaičius turi būti atskirtas nauja eilute.

3. Užduotis: Skaičių, kurie dalijasi iš 3, paieška
Sukurkite programą, kuri naudoja while ciklą norint rasti ir išvesti pirmus 10 skaičių nuo 1 iki 100, kurie dalijasi iš 3 be liekanos. Programa turi išvesti šiuos skaičius vieną po kito, kiekvieną naujoje eilutėje.


4. Užduotis:
Parašykite programą kuri prašo įvesti intervalą NUO/IKI ir jame atspausdina pirminius skaičius, skaičius kurie dalinasi iš 11 be liekanos

5. Užduotis: Sukurkite programą, kuri naudoja while ciklą, norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą.
Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti bei išvesti skaitmenų sumą. Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).*/

using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Console.WriteLine("Pradedama ketvirta uzduotis..");
            ketvirta();
            Console.WriteLine("Pradedama penkta uzduotis..");
            penkta();
            Console.WriteLine("Visos uzduotys buvo parodytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");

            void pirma()
            {
                /* 1.Užduotis: Skaičių sekos suma
    Parašykite programą, kuri naudoja while ciklą, kad suskaičiuotų visų teigiamų skaičių, mažesnių nei nurodytas skaičius 𝑛
    n, suma.Programa turi paprašyti vartotojo įvesti skaičių 𝑛
    n ir tada išvesti suskaičiuotą sumą.*/

                Console.WriteLine("Iveskite teigiama skaiciu, suskaiciuosime visu teigiamu skaiciu mazesniu, nei jusu nurodytas suma.");
                int ivestis = int.Parse(Console.ReadLine());
                int mazesnis = ivestis - 1;
                int suma = 0;
                Console.WriteLine($"Jusu ivestas skaicius {ivestis}");


                while (mazesnis > 0)
                {
                    suma += mazesnis;
                    mazesnis--;
                }

                Console.WriteLine($"Rezultatas: {suma}");


            }

            void antra()
            {
                /*2. Užduotis: Atvirkštinis skaičių išvedimas
    Parašykite programą naudojant for ciklą, kuri paprašo vartotojo įvesti skaičių 𝑛
    n ir tada išveda visus skaičius nuo 𝑛
    n iki 1 atvirkštine tvarka. Kiekvienas skaičius turi būti atskirtas nauja eilute.*/

                Console.WriteLine($"Iveskite skaiciu N, isvesime visus skaicius nuo N iki 1 atvirkstine tvarka.");
                int ivestis = int.Parse(Console.ReadLine());
                Console.WriteLine($"Jusu ivestas skaicius: {ivestis}");
                int atvir = ivestis--;



                for (atvir = ivestis--; atvir > 0; atvir--)

                {
                    Console.WriteLine(atvir);
                }



            }

            void trecia()
            {
                /*3. Užduotis: Skaičių, kurie dalijasi iš 3, paieška
    Sukurkite programą, kuri naudoja while ciklą norint rasti ir išvesti pirmus 10 skaičių nuo 1 iki 100, kurie dalijasi iš 3 be liekanos. Programa turi išvesti šiuos skaičius vieną po kito, kiekvieną naujoje eilutėje.*/

                Console.WriteLine("Pirmi 10 skaiciu nuo 1 iki 100 kurie dalijasi is 3 be liekanos");
                int pradzia = 1;
                int i = 0;

                while (i < 10 && pradzia <= 100)
                {
                    if(pradzia % 3 == 0)
                    {
                        Console.WriteLine(pradzia);
                        i++;
                    }
                    pradzia++;

                }

            }

            void ketvirta()
            {
                /*4. Užduotis:
    Parašykite programą kuri prašo įvesti intervalą NUO/IKI ir jame atspausdina pirminius skaičius, skaičius kurie dalinasi iš saves ir 11 be liekanos*/

                Console.WriteLine("Iveskite intervala NUO/IKI, atspausdinsime pirminius skaicius.\nNuo:");
                int nuo = int.Parse(Console.ReadLine());
                Console.WriteLine("Iki:");
                int iki = int.Parse(Console.ReadLine());

                if (nuo > iki)
                {
                    Console.WriteLine("Intervalas negalimas, skaiciuos NUO negali buti mazesnis, nei skaicius IKI");
                    return;
                }
                else
                {
                    Console.WriteLine($"Jusu pasirinkitas intervalas {nuo}/{iki}\nIsvedama pirminiai skaiciai...");
                }

                

                for (int i = nuo; i <= iki; i++)
                {
                    bool pirminis = yraPirminis(i);
                    
                    if (pirminis)
                    {
                        Console.WriteLine($"{i} yra pirminis skaičius.");
                    }

                    
                }

                

                static bool yraPirminis(int number)
                {
                    if (number <= 1)
                    {
                        return false;
                    }
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }


            }

            

            void penkta()
            {
                /*5. Užduotis: Sukurkite programą, kuri naudoja while ciklą, norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą.
    Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti bei išvesti skaitmenų sumą. Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).*/

                Console.WriteLine("Iveskite keliu skaitmenu ilgio skaiciu, apskaiciuosime skaitmenu suma");
                int ivestis = int.Parse(Console.ReadLine());
                int suma = 0;
                

                while(ivestis != 0)
                {
                    int paskutinis = ivestis % 10;
                    suma += paskutinis;
                    ivestis /= 10;

                }

                Console.WriteLine($"Ivestu skaitmenu suma: {suma}");

            }


        }

        
    }
}