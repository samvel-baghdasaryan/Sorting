using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{
    public static int[] Sort(int[] inputArray)
    {
        int[] arrayCopy = new int[inputArray.Length];
        Array.Copy(inputArray, arrayCopy, inputArray.Length);
        inputArray = arrayCopy;

        QuickSortRecursion(inputArray, 0, inputArray.Length - 1);
        return inputArray;
    }


    private static void QuickSortRecursion(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSortRecursion(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSortRecursion(arr, pivot + 1, right);
            }
        }

    }

    private static int partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


            }
            else
            {
                return right;
            }
        }
    }
}
