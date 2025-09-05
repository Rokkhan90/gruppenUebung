using System;

public class BubbleSort 
{
    public static void Main(string[] args)
    {
        int[] zahlen = { 15, 6, 82, 2, 88 };
        Console.WriteLine("Unsortierte Zahlen:");
        DruckeArray(zahlen);

        Sortiere(zahlen);

        Console.WriteLine("\nSortierte Zahlen:");
        DruckeArray(zahlen);
    }

    public static void Sortiere(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Die innere Schleife durchläuft das Array
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void DruckeArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}