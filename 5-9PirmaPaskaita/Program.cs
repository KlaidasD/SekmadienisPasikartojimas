using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

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

			static void pirma()

			{
				/*/*Sukurkite 4 kintamuosius, kurie saugotų jūsų vardą, pavardę, gimimo metus ir šiuos metus (nebūtinai tikrus).
 * Parašykite kodą, kuris pagal gimimo metus paskaičiuotų jūsų amžių ir naudodamas vardo ir pavardės kintamuosius atspausdintų tokį sakinį :
	"Aš esu Vardenis Pavardenis. Man yra XX metai(ų)".*/

				string vardas = "Jonas";
				string pavarde = "Jonaitis";
				int gMetai = 1995;
				int dMetai = DateTime.Now.Year;
				int amzius = dMetai - gMetai;
				Console.WriteLine($"As esu {vardas} {pavarde}. Man yra {amzius} metai (-u).");

			}

			static void antra()

			{
				/*Sukurkite du kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes nuo 0 iki 4.
Didesnę reikšmę padalinkite iš mažesnės. Atspausdinkite rezultatą jį suapvalinę iki 2 skaičių po kablelio.*/
				Random rnd = new Random();

				double a = rnd.Next(0, 5);
				double b = rnd.Next(0, 5);
				Console.WriteLine($"2 Atsitiktiniai skaiciai nuo 0-4: a:{a} ir b:{b}\nBandysime didesne reiksme padalinti is mazesnes ir atspausdinti rezultata suapvaline iki 2 skaiciu po kablelio...");


				double didesne;
				double mazesne;


				if (a > b)
				{
					didesne = a;
					mazesne = b;
				}
				else
				{
					didesne = b;
					mazesne = a;
				}

				double rezultatas = didesne / mazesne;
				double rezultatas2 = Math.Round(rezultatas, 2);

				if (a == b)

				{
					Console.WriteLine("Skaiciai yra vienodi, negalima pasirinkti didesnio skaiciaus");
				}

				else if (a == 0 || b == 0)

				{
					Console.WriteLine("Dalyba is nulio negalima.");
				}

				else

				{
					Console.WriteLine($"Atsitiktiniai skaiciai a: {a} ir b: {b}.\nDidesnis is ju yra {didesne}.\nPadalinus {didesne} is {mazesne} gauname : {rezultatas}.\nSuapvalinus iki 2 skaiciu po kablelio : {rezultatas2}");
				}




			}

			static void trecia()

			{
				/*Naudokite funkcija new Random(). Sukurkite tris kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes nuo 0 iki 25.
Raskite ir atspausdinkite kintąmąjį turintį vidurinę reikšmę.*/

				Random rnd = new Random();
				int n1 = rnd.Next(0, 26);
				int n2 = rnd.Next(0, 26);
				int n3 = rnd.Next(0, 26);

				int vidurine;

				if ((n1 >= n2 && n1 <= n3) || (n1 <= n2 && n1 >= n3))
				{
					vidurine = n1;

				}
				else if ((n2 >= n1 && n2 <= n3) || (n2 <= n1 && n2 >= n3))
				{
					vidurine = n2;

				}
				else
				{
					vidurine = n3;

				}

                   Console.WriteLine($"Trys atsitiktiniai skaiciai yra: c: {n1} d: {n2} e: {n3}.\nVidurine reiksme turintis skaicius: {vidurine}");

            }

			static void ketvirta()
			{
				/*Įvedami skaičiai - a, b, c –kraštinių ilgiai, trys kintamieji (naudojame int) (naudokite new Random() funkcija nuo 1 iki 10). 
Parašykite C# programą, kuri nustatytų, ar galima sudaryti trikampį ir atsakymą atspausdintų.
				Formule: 2 betkuriu krastiniu suma didesne uz trecios krastines ilgi = trikampi sudaryti galima
				a + b > c
				a + c > b
				b +c > a
				 */
				Random rnd = new Random();
				int k1 = rnd.Next(1, 11);
				int k2 = rnd.Next(1, 11);
				int k3 = rnd.Next(1, 11);

				Console.WriteLine($"Gautos trys atsitiktinio ilgio krastines a: {k1} b: {k2} c: {k3}\nApskaiciuojama ar galima is siu krastiniu sudaryti trikampi...");

				if (k1 + k2 > k3 && k1 + k3 > k2 && k2 + k3 > k1)
				{
					Console.WriteLine("Trikampi is siu krastiniu sudaryti galima.");
				}
				else
				{
					Console.WriteLine("Trikampio is siu krastiniu sudaryti negalima.");
				}

			}
			static void penkta()
			{
				/*Sukurkite keturis kintamuosius ir new Random() funkcija sugeneruokite jiems
reikšmes nuo 0 iki 2.Suskaičiuokite kiek yra nulių, vienetų ir dvejetų. (sprendimui masyvo nenaudoti).*/

				Random rnd = new Random();

				int r1 = rnd.Next(0, 3);
				int r2 = rnd.Next(0, 3);
				int r3 = rnd.Next(0, 3);
				int r4 = rnd.Next(0, 3);

				Console.WriteLine($"Gauti 4 atsitiktiniai skaiciai: {r1}, {r2}, {r3}, {r4}, apskaiciuojama kiek tarp ju yra nuliu, vienetu ir dvejetu.");

				int nuliai = 0;
				int vienetai = 0;
				int dvejetai = 0;

                if (r1 == 0)
                {
                    nuliai++;
                }
                else if (r1 == 1)
                {
                    vienetai++;
                }
                else
                {
                    dvejetai++;
                }

                if (r2 == 0)
                {
                    nuliai++;
                }
                else if (r2 == 1)
                {
                    vienetai++;
                }
                else
                {
                    dvejetai++;
                }

                if (r3 == 0)
                {
                    nuliai++;
                }
                else if (r3 == 1)
                {
                    vienetai++;
                }
                else
                {
                    dvejetai++;
                }

                if (r4 == 0)
                {
                    nuliai++;
                }
                else if (r4 == 1)
                {
                    vienetai++;
                }
                else
                {
                    dvejetai++;
                }

                Console.WriteLine($"Skaiciuose rasta: {nuliai} nuliai, {vienetai} vienetai, {dvejetai} dvejetai");

            }


            
				

			
		}

	}
}






