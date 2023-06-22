using System;
namespace zad4
{
    public class zad5
    {
        public zad5()
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 4, 7 }; // Przykładowa tablica przed sortowaniem

            SortowaniePrzezWybieranie(tablica);

            Console.WriteLine("Posortowana tablica:");
            WypiszTablice(tablica);

        }

        static void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indeksMinimum = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[indeksMinimum])
                    {
                        indeksMinimum = j;
                    }
                }

                // Zamiana miejscami
                int temp = tablica[i];
                tablica[i] = tablica[indeksMinimum];
                tablica[indeksMinimum] = temp;
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

