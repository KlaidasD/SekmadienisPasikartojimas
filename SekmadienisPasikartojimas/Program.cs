using System;
using System.Collections.Generic;

namespace Sekmadenis
{
    public class Program
    {
        Random rnd = new Random();  
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
            Console.WriteLine("Visos uzduotys buvo parodytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");


            static void pirma()
            {
                /* Užduotis 1: Sveikinimo programa
Sukurkite programą, kuri paprašytų vartotojo įvesti savo vardą ir po to pasveikintų jį išvedant tekstą į konsolę.*/

                Console.WriteLine("Sveiki, iveskite savo varda");
                string varVardas = Console.ReadLine();
                Console.WriteLine($"Sveiki {varVardas}.");

            }

            static void antra()
            {
                /*Užduotis 2: Aritmetinės operacijos
Sukurkite programą, kuri leistų vartotojui įvesti du skaičius ir atspausdintų jų sumą, skirtumą, sandaugą ir dalmenį.
*/

                Console.WriteLine("Iveskite du skaicius, atspausdinsime ju suma, skirtuma sandauga ir dalmeni.\nIveskite pirma skaiciu:");
                double pirmasSkaicius = double.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite antra skaiciu:");
                double antrasSakcius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Jusu ivesti skaiciai yra : {pirmasSkaicius} ir {antrasSakcius}");
                double suma = pirmasSkaicius + antrasSakcius;
                double skirtumas = pirmasSkaicius - antrasSakcius;
                double sandauga = pirmasSkaicius * antrasSakcius;
                double dalmuo = pirmasSkaicius / antrasSakcius;
                Console.WriteLine($"Jusu skaiciu suma : {suma}\nSkirtumas tarp jusu skaiciu : {skirtumas}\nJusu skaiciu sandauga : {sandauga}\nJusu skaiciu dalmuo : {dalmuo}");

            }

            static void trecia()
            {

                /*Užduotis 3: Amžiaus skaičiavimas
Sukurkite programą, kuri paprašytų vartotojo įvesti savo gimimo metus ir apskaičiuotų bei atspausdintų vartotojo amžių.*/

                Console.WriteLine("Sveiki! Iveskite savo gimimo metus apskaiciuosime jusu amziu.\nIveskite gimimo metus");
                int vMetai = int.Parse(Console.ReadLine());
                int dMetai = DateTime.Now.Year;
                int vAmzius = dMetai - vMetai;
                Console.WriteLine($"Jusu ivesti gimimo metai: {vMetai}, jusu amzius yra : {vAmzius} metai (-u).");
                int dMenuo = DateTime.Now.Month;
                int dDiena = DateTime.Now.Day;
                int tAmzius = vAmzius - 1;
                Console.WriteLine($"Jeigu gimete veliau,nei {dMenuo} menuo ir {dDiena} diena jums yra: {tAmzius} metai(-u).");

            }

            static void ketvirta()
            {
                /*Užduotis 4: Temperatūros konversija
Sukurkite programą, kuri leistų vartotojui įvesti temperatūrą Farenheito skalėje ir paskaičiuotų bei atspausdintų temperatūrą Celsijaus skalėje.
               formule : °C equals °F minus 32, divided by 9/5. °C = ( °F - 32) ÷ 9/5. */

                Console.WriteLine("Pradedama temperaturos konversijos programa...\nIveskite temperatura Farenheito skaleje, konvertuosime i Celsijaus skale.\nIveksite temperatura: ");
                double farenheit = double.Parse(Console.ReadLine());
                double celsius = (farenheit - 32) / 1.8;
                Console.WriteLine($"Jusu ivesta temperatura Farnheito skaleje : {farenheit}, konvertavus ja i Celsijaus skale gauname : {celsius}.");

            }

        }

        



    }
}
