using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace számológép
{
	internal class Program
	{
		static float szam1 = 0;
		static float szam2 = 0;



		static void Main(string[] args)
		{
			Console.Write("Addj meg számot: ");
			szam1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Addj meg egy másik számot: ");
			szam2 = Convert.ToInt32(Console.ReadLine());


			Osszeadas();
			Kivonas();
			Osztas();
			Szorzas();
			Szazalek();
		}
		static void Osszeadas()
		{
			float ossz = szam1 + szam2;
            Console.WriteLine($"Két szám összeadava: {ossz}");
        }
		static void Kivonas()
		{
			float kivon = szam1 - szam2;
			Console.WriteLine($"Két szám kivonva egymásból: {kivon}");
		}
		static void Osztas()
		{
			float oszt = szam1 / szam2;
			Console.WriteLine($"Két szám hányadosa: {oszt}");
		}
		static void Szorzas()
		{
			float szor = szam1 * szam2;
			Console.WriteLine($"Két szám szorzata: {szor}");
		}
		static void Szazalek()
		{
			float szaz = (szam2 / szam1) * 100;
			Console.WriteLine($"A második szám {szaz} százaléka az elsőnek");
		}
	}
}
