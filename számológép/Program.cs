﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace számológép
{
	internal class Program
	{
		static int szam1 = 0;
		static int szam2 = 0;



		static void Main(string[] args)
		{
			Console.Write("Addj meg számot: ");
			szam1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Addj meg egy másik számot: ");
			szam2 = Convert.ToInt32(Console.ReadLine());


			Osszeadas();
			Kivonas();
		}
		static void Osszeadas()
		{
			int ossz = szam1 + szam2;
            Console.WriteLine($"Két szám összeadava: {ossz}");
        }
		static void Kivonas()
		{
			int kivon = szam1 - szam2;
			Console.WriteLine($"Két szám kivonva egymásból: {kivon}");
		}
	}
}
