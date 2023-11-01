using System;

class Program
{
    static void ResizeArray(ref int[] array, int newSize)
    {
        int[] newArray = new int[newSize];
        Array.Copy(array, newArray, Math.Min(array.Length, newSize));
        array = newArray;
    }

    static void Main()
    {
        int[] Array = { 1, 2, 3, 4, 5 };
        
        foreach (var item in Array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int newSize = 10; 
        ResizeArray(ref Array, newSize);
        
        Console.WriteLine("resized array:");
        foreach (var item in Array)
        {
            Console.Write(item  + " " );
        }
    }
}
