using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InsertionSort;
using static BubbleSort;
using static HeapSort;
using static MergeSort;
using static QuickSort;


class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Please enter the size of an array that you want to sort: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] numbers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = random.Next(-100, 100);
        }

        Console.WriteLine("1. Insertion sort");
        Console.WriteLine("2. Bubble sort");
        Console.WriteLine("3. Quick sort");
        Console.WriteLine("4. Heap sort");
        Console.WriteLine("5. Merge sort");
        Console.WriteLine("6. All");
        Console.Write("Select which algorithm you want to perform: ");
        int algNum = int.Parse(Console.ReadLine());
        if (algNum == 1)
            BenchInsertionSort(numbers);
        else if (algNum == 2)
            BenchBubbleSort(numbers);
        else if (algNum == 3)
            BenchQuickSort(numbers);
        else if (algNum == 4)
            BenchHeapSort(numbers);
        else if (algNum == 5)
            BenchMergeSort(numbers);
        else if (algNum == 6)
        {
            BenchInsertionSort(numbers);
            BenchBubbleSort(numbers);
            BenchQuickSort(numbers);
            BenchHeapSort(numbers);
            BenchMergeSort(numbers);
        }

    }
    private static void BenchBubbleSort(int[] numbers)
    {
        Console.WriteLine("Bubble Sorting...");
        var memoryBefore = System.GC.GetTotalMemory(true);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        BubbleSort.Sort(numbers);
        var time = watch.ElapsedMilliseconds;
        var memoryAfter = System.GC.GetTotalMemory(false);
        Console.WriteLine("  Memory usage: {0} kbytes", (memoryAfter - memoryBefore) / 1024.0);
        Console.WriteLine("  Elapsed time: {0} seconds", time / 1000.0);
    }
    private static void BenchInsertionSort(int[] numbers)
    {
        Console.WriteLine("insertion Sorting...");
        var memoryBefore = System.GC.GetTotalMemory(true);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        InsertionSort.Sort(numbers);
        var time = watch.ElapsedMilliseconds;
        var memoryAfter = System.GC.GetTotalMemory(false);
        Console.WriteLine("  Memory usage: {0} kbytes", (memoryAfter - memoryBefore) / 1024.0);
        Console.WriteLine("  Elapsed time: {0} seconds", time / 1000.0);
    }
    private static void BenchHeapSort(int[] numbers)
    {
        Console.WriteLine("Heap Sorting...");
        var memoryBefore = System.GC.GetTotalMemory(true);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        HeapSort.Sort(numbers);
        var time = watch.ElapsedMilliseconds;
        var memoryAfter = System.GC.GetTotalMemory(false);
        Console.WriteLine("  Memory usage: {0} kbytes", (memoryAfter - memoryBefore) / 1024.0);
        Console.WriteLine("  Elapsed time: {0} seconds", time / 1000.0);
    }
    private static void BenchQuickSort(int[] numbers)
    {
        Console.WriteLine("Quick Sorting...");
        var memoryBefore = System.GC.GetTotalMemory(true);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        QuickSort.Sort(numbers);
        var time = watch.ElapsedMilliseconds;
        var memoryAfter = System.GC.GetTotalMemory(false);
        Console.WriteLine("  Memory usage: {0} kbytes", (memoryAfter - memoryBefore) / 1024.0);
        Console.WriteLine("  Elapsed time: {0} seconds", time / 1000.0);
    }
    private static void BenchMergeSort(int[] numbers)
    {
        Console.WriteLine("Merge Sorting...");
        var memoryBefore = System.GC.GetTotalMemory(true);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        MergeSort.Sort(numbers);
        var time = watch.ElapsedMilliseconds;
        var memoryAfter = System.GC.GetTotalMemory(false);
        Console.WriteLine("  Memory usage: {0} kbytes", (memoryAfter - memoryBefore) / 1024.0);
        Console.WriteLine("  Elapsed time: {0} seconds", time / 1000.0);
    }
}
