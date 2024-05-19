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
            Console.WriteLine("Pradedama ketvirta uzduotis..");
            ketvirta();
            Console.WriteLine("Visos uzduotys buvo parodytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");

            void pirma()
            {
                Random rnd = new Random();
                spausdinkKitaip(rnd.Next(1900, 2000));

                /*Sukurkite metodą, kuris priima metų skaičių ir atspausdina, 
	kiek mėnesių, dienų ir valandų tai yra. Tarkime kad metai turi 365 dienas.
	Pvz.: "16 metu, tai: 192 menesiu, 5840 dienu, 140160 valandu." */

                void spausdinkKitaip(int metai)
                {
                    int menesiai = metai * 12;
                    int dienos = metai * 365;
                    int valandos = dienos * 24;

                    Console.WriteLine($"{metai} metu, tai : {menesiai} menesiu, {dienos} dienu, {valandos} valandu.");

                }



            }

            void antra()
            {

                poVidurnakcio(DateTime.Now);

                void poVidurnakcio(DateTime dabar)
                {

                    int praejoMin = (dabar.Hour * 60) + dabar.Minute;
                    Console.WriteLine($"Siuo metu yra {dabar}. Tai praejo {praejoMin} minutes (arba {praejoMin * 60} sekundziu) po vidurnakcio. ");

                }


            }

            void trecia()
            {
                /*Sukurkite metodą, kuris suskaičiuoja, kiek knygų k vidutiniškai per metus perskaito
	vienas mokyklos bibliotekos lankytojas. Žinomas vidutiniškai per mėnesį perskaitytų
	knygų skaičius v ir vidutiniškai per metus apsilankiusių bibliotekoje skaičius n. 
	
	galite naudoti random skaicius:*/

                Random rnd = new Random();

                kiekKnygu(rnd.Next(10, 50), rnd.Next(5, 10));

                void kiekKnygu(int v, int n)
                {
                    double k = (double)v / n;
                    Console.WriteLine($"Vidutiniskai per menesi perskaitytu knygu skaicius: {v} ir vidutiniskai apsilankiusiu bibliotekoje zmoniu skaicius {n}, reiskiasi vienas bibliotekos lankytojas vidutiniskai perskaito {k} knygu per metus.");
                }

            }

            void ketvirta()
            {
                /*Sukurkite metodą, kuris suskaičiuoja, kiek vidutiniškai keleivių k važiuoja į Vilnių
	viename traukinio vagone, jei žinomas traukinio keleivių skaičius n, keleivių, vykstančių
	ne į Vilnių skaičius m ir vagonų skaičius v. 

	galite naudoti random skaicius:*/

                Random rnd = new Random();

                vidutiniskaiK(rnd.Next(5, 10), rnd.Next(1, 3), rnd.Next(1, 4));

                    void vidutiniskaiK(int n, int m, int v)
                {
                    double k = (double)(n - m) / v;
                    Console.WriteLine($"Traukinio keleiviu skaicius {n}, keleiviu kuria vyksta ne i Vilniu skaicius {m} ir vagonu skaicius {v}.");
                    Console.WriteLine($"I Vilniu viename traukinio vagone vidutiniskai vyksta {k} keleiviu.");
                }

            }
        }


    }
}

