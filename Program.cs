using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 12, 4, 56, 7, 23, 89, 45, 3, 10 };
        Console.WriteLine("Array antes da ordenação:");
        PrintArray(array);

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("\nArray depois da ordenação:");
        PrintArray(array);
    }

    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[right]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
