/* Sukurkite masyvą su dešimties augalų pavadinimais.
Atspausdinkite kiekvieną uždavinio augalą atskiroje eilutėje.
Atspausdinkite uždavinio kiekvieną augalą pradedant nuo paskutinio, ir baigiant pirmuoju. (atvirkščias ciklas).
Suskaičiuokite kiek uždavinio masyve yra žodžių trumpesnių nei 5 simboliai, ir kiek ilgesnių nei 7 simboliai. (du skaičiavimai)
Suskaičiuokite kiek uždavinio masyve yra žodžių ilgesnių nei 5 simboliai bet trumpesnių  nei 10 simboliai. (tarp 5 ir 10 simbolių ilgio)*/

using System;

namespace Sekmadienis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] augalai = new string[10];

            augalai[0] = "Roze"; 
            augalai[1] = "Egle";
            augalai[2] = "Klevas";
            augalai[3] = "Orchideja";
            augalai[4] = "Kaktusas";
            augalai[5] = "Palme";
            augalai[6] = "Magnolija";
            augalai[7] = "Berzas";
            augalai[8] = "Tulpe";
            augalai[9] = "Lilija";

            Console.WriteLine("Spausdinamas augalu masyvas...");
            
            for(int i = 0; i < augalai.Length; i++)
            {
                Console.WriteLine(augalai[i]);
            }

            Console.WriteLine("Dabar spausdinami tie patys augalai, bet atvirksciai");

            for(int i = 9; i > 0; i--)
            {
                Console.WriteLine(augalai[i]);
            }
            int trump = 0;
            int ilgesni = 0;


            for(int i = 0; i < augalai.Length; i++)
            {
                if (augalai[i].Length < 5)
                {
                    trump++;
                }

                if (augalai[i].Length > 7)
                {
                    ilgesni++;
                }
            }

            Console.WriteLine($"Kiekis trumpesniu, nei 5 simboliu augalu : {trump}\nIlgesniu, nei 7 simboliu augalu kiekis: {ilgesni}");

            int tarp = 0;

            for(int i = 0; i < augalai.Length;i++)
            {
                if (augalai[i].Length > 5 && augalai[i].Length < 10)
                {
                    tarp++;
                }
            }

            Console.WriteLine($"Augalai tarp 5 ir 10 simboliu ilgio: {tarp}");


        }
    }
}

