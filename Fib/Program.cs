using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
	class Program
	{
		//Kolatzova teorema
		//--------------
		//Korisnik unese broj
		//Proveravamo da li je broj paran
		//Ako je paran, delimo ga sa dva i nastavljamo
		//Ako je neparan, mnozimo ga sa 3, dodajemo 1 i nastavljamo
		//Moramo da stignemo do broja 1

		//hgfhgfhgf


		static void Main(string   [] args)
		{   //     p pp    t
			// 0   1   1  2  3   5  8  13  21  34   55
			//trenutni = p + pp

			long p = 0;
			long pp = 1;
			for (int brojac = 0; brojac < 100; brojac++)
			{
				long trenutni = p + pp;
				Console.WriteLine(trenutni);
				p = pp;
				pp = trenutni;
			}
			Console.ReadKey();
		}
	}
}
