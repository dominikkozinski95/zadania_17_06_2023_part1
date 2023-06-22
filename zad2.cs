using System;
namespace zad4
{
	public class zad2
	{
		public zad2()
		{
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 4, 7 }; // Przykładowa tablica

            int najmniejszy = ZnajdzNajmniejszy(tablica);
            int najwiekszy = ZnajdzNajwiekszy(tablica);

            Console.WriteLine("Najmniejszy element: " + najmniejszy);
            Console.WriteLine("Największy element: " + najwiekszy);
        }

        static int ZnajdzNajmniejszy(int[] tablica)
        {
            int najmniejszy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszy)
                {
                    najmniejszy = tablica[i];
                }
            }

            return najmniejszy;
        }

        static int ZnajdzNajwiekszy(int[] tablica)
        {
            int najwiekszy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > najwiekszy)
                {
                    najwiekszy = tablica[i];
                }
            }

            return najwiekszy;
        }

    }
}

