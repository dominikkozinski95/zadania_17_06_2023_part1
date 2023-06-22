namespace zad4;
class Zad1
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10); // Przykładowa tablica o rozmiarze 10
        WypiszOdTylu(tablica);
    }

    static int[] GenerujTablice(int rozmiar)
    {
        Random rand = new Random();
        int[] tablica = new int[rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(100); // Losowa wartość od 0 do 99
        }

        return tablica;
    }

    static void WypiszOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}

