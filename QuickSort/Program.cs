class Program
{
    static void Main()
    {
        int[] array = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

        Console.WriteLine("Array antes da ordenação:");
        Console.WriteLine(string.Join(", ", array));

        QuickSort.Sort(array);

        Console.WriteLine("Array após a ordenação:");
        Console.WriteLine(string.Join(", ", array));
    }
}