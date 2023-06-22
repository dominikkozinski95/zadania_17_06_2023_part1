using System;

namespace Application
{
    public class zad3
    {
        public zad3()
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 4, 7 }; // Przykładowa tablica przed sortowaniem

            SortowanieBabelkowe(tablica);

            Console.WriteLine("Posortowana tablica:");
            WypiszTablice(tablica);
        }


        static void SortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;
            bool zamiana;

            for (int i = 0; i < n - 1; i++)
            {
                zamiana = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        // Zamiana miejscami
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                        zamiana = true;
                    }
                }

                // Jeśli w tej iteracji nie było żadnej zamiany, tablica jest już posortowana
                if (!zamiana)
                {
                    break;
                }
            }
        }

        static void WypiszTablice(int[] tablica)
        {
            foreach (int element in tablica)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

