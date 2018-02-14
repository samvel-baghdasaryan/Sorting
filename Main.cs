using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10] {2, 5, -4, 11, 0, 18, 22, 67, 51, 6};
        Console.WriteLine("\nOriginal Array Elements :");
		PrintIntegerArray(numbers);
        InsertionSort(numbers);
        Console.WriteLine("\nSorted Array Elements :");
        PrintIntegerArray(InsertionSort(numbers));
		Console.WriteLine("\n");
        }
        
    public static void PrintIntegerArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i.ToString() + "  ");
        }
     }

 }