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
            Console.WriteLine("Pradedama papildoma ketvirta uzduotis..");
            papildomaKetvirta();
            Console.WriteLine("Pradedama papildoma penkta uzduotis..");
            papildomaPenkta();
            Console.WriteLine("Visos uzduotys buvo parodytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");
        }
        static void pirma()
        {

            /*Naudokite funkcija new Random(). Sukurkite ir atspausdinkite 3 skaičius nuo -10 iki 10. Skaičiai mažesni už 0 turi būti  laužtiniuose skliaustuose [], 0 -  (), didesni už 0 {}.*/

            Random rnd = new Random();
            int a = rnd.Next(-10, 11);
            int b = rnd.Next(-10, 11);
            int c = rnd.Next(-10, 11);

            Console.WriteLine($"Gauti 3 atsitiktiniai skaiciai: {a}, {b} ir {c}\nAtspausdinama kaip nurodyta uzduotyje:");

            if (a < 0)
            {
                Console.WriteLine($"[{a}]");
            }
            else if (a == 0)
            {
                Console.WriteLine($"({a})");
            }
            else
            {
                Console.WriteLine($"{{{a}}}");
            }

            if (b < 0)
            {
                Console.WriteLine($"[{b}]");
            }
            else if (b == 0)
            {
                Console.WriteLine($"({b})");
            }
            else
            {
                Console.WriteLine($"{{{b}}}");
            }

            if (c < 0)
            {
                Console.WriteLine($"[{c}]");
            }
            else if (c == 0)
            {
                Console.WriteLine($"({c})");
            }
            else
            {
                Console.WriteLine($"{{{c}}}");
            }


        }

        static void antra()
        {
            /*Įmonė parduoda žvakes po 1 EUR. Perkant daugiau kaip 1000 vienetų taikoma 3 % nuolaida, daugiau kaip 2000 vienetų- 4 % nuolaida. 
Parašykite programą, kuri skaičiuos žvakių kainą ir atspausdintų atsakymą kiek žvakių ir kokia kaina perkama. Žvakių kiekį generuokite new Random() funkcija nuo 5 iki 3000.*/

            Random rnd = new Random();

            double zKaina = 1;
            int pKiekis = rnd.Next(5, 3001);
            Console.WriteLine($"Iprastine zvakiu kaina 1 EUR.\nJusu perkamas kiekis {pKiekis}, apskaiciuojama ar priklauso nuolaida nuo perkamo kiekio...");

            if(pKiekis > 1000)
            {
                zKaina *= 0.97;
                Console.WriteLine("Jums priklauso 3% nuolaida.");
            }
            else if (pKiekis > 2000)
            {
                zKaina *= 0.96;
                Console.WriteLine("Jums priklauso 4% nuolaida.");
            }
            else
            {
                Console.WriteLine("Kadangi perkate maziau, nei 1000 vienetu, jums nuolaida nera pritaikoma.");
            }

            double suma = zKaina * pKiekis;
            Console.WriteLine($"Suma apmokejimui: {suma}EUR");

        }

        static void trecia()
        {
            /*Naudokite funkcija new Random(). Sukurkite tris kintamuosius su atsitiktinėm reikšmėm nuo 0 iki 100. Paskaičiuokite jų aritmetinį vidurkį.
Ir aritmetinį vidurkį atmetus tas reikšmes, kurios yra mažesnės nei 10 arba didesnės nei 90. Abu vidurkius atspausdinkite. Rezultatus apvalinkite iki sveiko skaičiaus.*/

            Random rnd = new Random();
            int r1 = rnd.Next(0, 101);
            int r2 = rnd.Next(0, 101);
            int r3 = rnd.Next(0, 101);
            double vidurkis = r1 + r2 + r3 / 3;
            double vidurkisA = Math.Round(vidurkis);

            Console.WriteLine($"Trys atsitiktiniai skaiciai yra: {r1}, {r2} ir {r3}\nJu vidurkis: {vidurkis}\nVidurkis suapvalintas iki sveiko skaiciaus:{vidurkisA}");

            if(r1 < 10)
            {
                r1 = 0;
            }
            else if (r1 > 90)
            {
                r1 = 0;
            }
            if (r2 < 10)
            {
                r2 = 0;
            }
            else if (r2 > 90)
            {
                r2 = 0;
            }
            if (r3 < 10)
            {
                r3 = 0;
            }
            else if (r3 > 90)
            {
                r1 = 0;
            }

            double vidurkisbe = r1 + r2 + r3 / 3;
            double vidurkisbeA = Math.Round(vidurkisbe);    

            Console.WriteLine($"Aritmetinis vidurkis atmetus tas reiksmes kurios yra mazesnes nei 10 arba didesne nei 90: {vidurkisbe}\nVidurkis be nurodytu reiksmiu ir suapvalintas iki sveiko skaiciaus:{vidurkisbeA}");


        }

        static void papildomaKetvirta()
        {
            /*Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes. Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės. Skaičių pridėkite prie jau sugeneruoto laiko. Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.*/

            Random rnd = new Random();

            int val = rnd.Next(0, 24);
            int min = rnd.Next(0, 60);
            int sek = rnd.Next(0, 60);
            int pSek = rnd.Next(0, 301);
            Console.WriteLine($"Dabartinis laikas yra: {val}H, {min}MIN ir {sek}SEK.\nPridedamos papildomos {pSek} sekundes.");

            int pridetos = sek + pSek;

            min += pridetos / 60;
            pridetos %= 60;
            val += min / 60;
            min %= 60;
            val %= 24;

            Console.WriteLine($"Laikas po pridetu papildomu sekundziu: {val}H, {min}MIN ir {pridetos}SEK.");

        }


        static void papildomaPenkta()
        {
            /*Naudokite funkcija new Random(). Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm nuo 1000 iki 9999.
Atspausdinkite reikšmes viename stringe, išrūšiuotas nuo didžiausios iki mažiausios, atskirtas tarpais. Naudoti ciklų ir masyvų NEGALIMA.*/





        }
    }
}