/*Užduotis 6: Savaitės dienų atvaizdavimas
Sukurkite programą, kuri paprašytų vartotojo įvesti savaitės dienos numerį (1 iki 7) ir pagal tai atspausdintų dienos pavadinimą naudojant switch sakinį.


Užduotis 7: Įvestų duomenų tipo atpažinimas
Sukurkite programą, kuri atskirtų kokio tipo t.y (int, string) (tik šių 2) tipo reikšmė buvo įvesta.
Jeigu tai int kintamasis tai jį reikia padauginti iš 11 ir atvaizduoti ekrane.
Jeigu tai string tipo kintamasis reikia prieš jį pridėti # ir po jo pridėti # ir atvaizduoti naują reikšmę ekrane*/

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
            Console.WriteLine("Visos uzduotys padarytos, paspauskite betkuri mygtuka, kad uzdaryti programa.");

            void pirma()

            {
                /*Užduotis 6: Savaitės dienų atvaizdavimas
Sukurkite programą, kuri paprašytų vartotojo įvesti savaitės dienos numerį (1 iki 7) ir pagal tai atspausdintų dienos pavadinimą naudojant switch sakinį.*/

                Console.WriteLine("Iveskite savaites diena numeriu 1-7 ir mes parasysime jos pavadinima.");
                int ivestis = int.Parse(Console.ReadLine());
                string zodziais;

                switch (ivestis)
                {
                    case 1:
                        zodziais = "Pirmadienis";
                        break;
                    case 2:
                        zodziais = "Antradienis";
                        break;
                    case 3:
                        zodziais = "Treciadienis";
                        break;
                    case 4:
                        zodziais = "Ketvirtadienis";
                        break;
                    case 5:
                        zodziais = "Penktadienis";
                        break;
                    case 6:
                        zodziais = "Sestadienis";
                        break;
                    case 7:
                        zodziais = "Sekmadienis";
                        break;
                    default:
                        zodziais = "Nera tokios dienos";
                        break;

                }

                Console.WriteLine($"Jusu pasirinkta savaites diena zodziais: {zodziais}.");

            }

            void antra()
            {

                /*Užduotis 7: Įvestų duomenų tipo atpažinimas
Sukurkite programą, kuri atskirtų kokio tipo t.y (int, string) (tik šių 2) tipo reikšmė buvo įvesta.
Jeigu tai int kintamasis tai jį reikia padauginti iš 11 ir atvaizduoti ekrane.
Jeigu tai string tipo kintamasis reikia prieš jį pridėti # ir po jo pridėti # ir atvaizduoti naują reikšmę ekrane*/

                Console.WriteLine("Iveskite skaiciu arba teksta, mes atpazinsime jusu ivesties tipa, skaiciu padauginsime is 11, o teksta koreguosime pridedami # pradzioje ir pabaigoje.");

                string tipas = Console.ReadLine();
                   
                if (int.TryParse(tipas, out int number))
                {
                    int ats = number * 11;
                    Console.WriteLine($"Jusu ivestis yra skaicius ir ji padauginus is 11 gauname : {ats}.");
                }
                else
                {
                    Console.WriteLine($"Jusu ivestis yra tekstas, jus ivedete #{tipas}#");
                }
               

                

                   


                

            }



        }
    }
}

