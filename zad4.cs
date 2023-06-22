using System;
namespace zad4
{
    public class zad4
    {
        public zad4()
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 4, 7 }; // Przykładowa tablica przed sortowaniem

            SortowaniePrzezWstawianie(tablica);

            Console.WriteLine("Posortowana tablica:");
            WypiszTablice(tablica);
        }

        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 1; i < n; i++)
            {
                int obecnyElement = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > obecnyElement)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = obecnyElement;
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
