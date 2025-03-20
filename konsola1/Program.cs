using System;

class Program
{
    /// <summary>
    /// metoda programu. Generuje tablicę, pobiera wartość do wyszukania od użytkownika.Przeszukuje tablicę i wyświetla wyniki.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(50, 1, 100);
        Console.WriteLine("Wprowadź wartość do wyszukania:");
        if (int.TryParse(Console.ReadLine(), out int valueToFind))
        {
            int index = SearchWithSentinel(array, valueToFind);
            Console.WriteLine("Tablica: " + string.Join(", ", array));
            if (index == array.Length)
            {
                Console.WriteLine("Nie znaleziono wartości " + valueToFind + " w tablicy.");
            }
            else
            {
                Console.WriteLine("Wartość " + valueToFind + " znaleziona na indeksie: " + index);
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa wartość wejściowa.");
        }}
    /// <summary>
    ///  Generuje tablicę liczb losowych.
    /// </summary>
    /// <param name="size">Rozmiar tablicy.</param>
    /// <param name="minValue">Minimalna wartość </param>
    /// <param name="maxValue">Maksymalna wartość</param>
    /// <returns></returns>
    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }
    /// <summary>
    /// Przeszukuje tablice.
    /// </summary>
    /// <param name="array">tablica do przeszukania</param>
    /// <param name="value">wartość do wyszukania</param>
    /// <returns>Indeks znalezionego elementu lub długość tablicy,jeśli element nie został znaleziony</returns>
    static int SearchWithSentinel(int[] array, int value)
    {
        int n = array.Length;
        int[] extendedArray = new int[n + 1];
        Array.Copy(array, extendedArray, n);
        extendedArray[n] = value; 
        int i = 0;
        while (extendedArray[i] != value)
        {
            i++;
        }
        return i;
    }
}

