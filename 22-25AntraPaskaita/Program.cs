/*6. Užduotis: Temperatūrų vidurkio skaičiavimas
Parašykite programą, kuri leidžia vartotojui įvesti temperatūras kelias dienas. Masyvas turi būti naudojamas temperatūroms saugoti.
Po to, kai visos temperatūros įvestos, programa turi naudoti for ciklą, kad apskaičiuotų ir išvestų temperatūrų vidurkį.

7. Užduotis: Maksimalios ir minimalios reikšmės radimas
Sukurkite programą, kuri paprašo vartotojo įvesti skaičių seriją į masyvą. Naudokite for ciklą, kad rastumėte didžiausią ir mažiausią skaičius masyve.
Panaudokite if sąlyginius teiginius, kad nustatytumėte, kuris skaičius yra didžiausias, o kuris - mažiausias, ir išveskite juos į ekraną.

8. Užduotis: Skaičių filtravimas
Parašykite programą, kurioje vartotojas įveda skaičių seriją į masyvą, o programa naudoja for ciklą ir if teiginį, kad atrinktų ir išvestų tik tuos skaičius, kurie yra didesni už vidutinę visų įvestų skaičių reikšmę.

9. Parašykite programą, kuri paprašo vartotojo įvesti tekstą. Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
Norėdami tai padaryti, galite naudoti 26 elementų masyvą, kur kiekvienas indeksas atitinka raidę (pvz., 0 atitinka A, 1 - B ir t.t.), o reikšmė masyve atitinka raidės pasikartojimo skaičių.*/

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
                /*Užduotis: Temperatūrų vidurkio skaičiavimas
    Parašykite programą, kuri leidžia vartotojui įvesti temperatūras kelias dienas. Masyvas turi būti naudojamas temperatūroms saugoti.
    Po to, kai visos temperatūros įvestos, programa turi naudoti for ciklą, kad apskaičiuotų ir išvestų temperatūrų vidurkį.*/

                Console.WriteLine("Iveskite dienu skaiciu kurioms pateiksite temperatura ir apskaiciuosim temperaturos vidurki toms dienomis.");
                int dSkaicius = int.Parse(Console.ReadLine());
                double[] temp = new double[dSkaicius];

                for (int i = 0; i < dSkaicius; i++)
                {
                    Console.WriteLine($"Iveskite temperatura {i + 1} dienai:");
                    temp[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Jusu ivestos temperaturos;");
                for (int i = 0; i < dSkaicius; i++)
                {
                    Console.WriteLine($"Jusu ivesta temperatura {i + 1} dienai {temp[i]}");
                }

                double suma = 0;

                for (int i = 0;i < dSkaicius; i++)
                {
                    suma += temp[i];
                }

                double vidurkis = suma / dSkaicius;
                Console.WriteLine($"Jusu ivestu temperaturu suma yra {suma} ir ju vidurkis yra: {vidurkis}");

            }

            void antra()
            {
                /*Užduotis: Maksimalios ir minimalios reikšmės radimas
    Sukurkite programą, kuri paprašo vartotojo įvesti skaičių seriją į masyvą. Naudokite for ciklą, kad rastumėte didžiausią ir mažiausią skaičius masyve.
    Panaudokite if sąlyginius teiginius, kad nustatytumėte, kuris skaičius yra didžiausias, o kuris - mažiausias, ir išveskite juos į ekraną.*/

                Console.WriteLine("Iveskite skaiciu serija, mes isvesime didziausia ir maziausia skaiciu.");
                Console.WriteLine("Kiek kartu norite ivesti skaicius?:");
                int skaiciu = int.Parse(Console.ReadLine());

                if (skaiciu < 2)
                {
                    Console.WriteLine("Turite ivesti daugiau, nei 1 skaiciu kombinacija.");
                    return;
                }
                        


                
                int[] masyvas = new int[skaiciu];

                for (int i = 0;i<skaiciu;i++)
                {
                    Console.WriteLine($"Iveskite {i + 1} skaiciu:");
                    masyvas[i] = int.Parse(Console.ReadLine()); 
                }

                int max = masyvas[0];
                int min = masyvas[0];

                for (int i = 1;i<skaiciu;i++)
                { 
                    if (masyvas[i] > max)
                    {
                        max = masyvas[i];
                    }
                    else if (masyvas[i] < min)
                    {
                        min = masyvas[i];
                    }
                }

                Console.WriteLine($"Tarp jusu ivestu skaiciu {max} yra didziausias skaicius ir {min} yra maziausias skaicius.");

            }

            void trecia()
            {
                /*Užduotis: Skaičių filtravimas
    Parašykite programą, kurioje vartotojas įveda skaičių seriją į masyvą, o programa naudoja for ciklą ir if teiginį, kad atrinktų ir išvestų tik tuos skaičius, kurie yra didesni už vidutinę visų įvestų skaičių reikšmę.*/

                Console.WriteLine("Iveskite skaiciu serija, mes isvesime tik tuos skaicius kurie yra didesni uz vidutine visu ivestu skaiciu reiksme");
                Console.WriteLine("Kiek skaiciu noresite ivesti?");

                int kiek = int.Parse(Console.ReadLine());
                int[] mas = new int[kiek];

                for(int i = 0;i < kiek; i++)
                {
                    Console.WriteLine($"Iveskite {i + 1} skaiciu");
                    mas[i] = int.Parse(Console.ReadLine()); 
                }

                for (int i = 0; i < kiek; i++)
                {
                    Console.WriteLine($"Jusu {i + 1} ivestas skaicius {mas[i]}");
                }

                int suma = 0;

                for (int i = 0;i < kiek; i++)
                {
                    suma += mas[i];
                }

                double vidurkis = suma / kiek;

                for (int i = 0; i < kiek; i++)
                {
                    if (mas[i] > vidurkis)
                    {
                        Console.WriteLine($"{i + 1} skaicius yra didesnis uz vidutine visu ivestu skaiciu reiksme {mas[i]}");
                    }
                }



            }

            void ketvirta()
            {
                /*Parašykite programą, kuri paprašo vartotojo įvesti tekstą. Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
    Norėdami tai padaryti, galite naudoti 26 elementų masyvą, kur kiekvienas indeksas atitinka raidę (pvz., 0 atitinka A, 1 - B ir t.t.), o reikšmė masyve atitinka raidės pasikartojimo skaičių.*/

                Console.WriteLine("Iveskite teksta ir apskaiciuosime kiek kartu jame pasikartoja kiekviena raide.");
                string ivestis = Console.ReadLine();
                ivestis = ivestis.ToUpper();
                int[] kartu = new int[26];

                foreach (char c in ivestis)
                {
                    // Check if the character is a letter (A-Z)
                    if (char.IsLetter(c))
                    {
                        // Calculate the index of the letter in the array (0 for 'A', 1 for 'B', etc.)
                        int index = c - 'A';

                        // Increment the count of occurrences for the corresponding letter
                        kartu[index]++;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    // Convert the index back to the corresponding letter
                    char c = (char)('A' + i);

                    // Print the letter and its count of occurrences
                    Console.WriteLine($"{c}: {kartu[i]}");
                }

                //^^^ ChatGPT skaiciavimai, nieko nesuprantu :D

            }
        }

     
    }
}

