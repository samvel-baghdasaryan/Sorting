using System;

class MergeSort
{
    public static int[] Sort(int[] inputArray)
    {
        int[] arrayCopy = new int[inputArray.Length];
        Array.Copy(inputArray, arrayCopy, inputArray.Length);
        inputArray = arrayCopy;

        MergeSortRecursion(inputArray, 0, inputArray.Length - 1);
        return inputArray;
    }

    private static void MergeSortRecursion(int[] input, int low, int high)
    {
        if (low < high)
        {
            int middle = (low / 2) + (high / 2);
            MergeSortRecursion(input, low, middle);
            MergeSortRecursion(input, middle + 1, high);
            Merge(input, low, middle, high);
        }
    }

    private static void Merge(int[] input, int low, int middle, int high)
    {

        int left = low;
        int right = middle + 1;
        int[] tmp = new int[(high - low) + 1];
        int tmpIndex = 0;

        while ((left <= middle) && (right <= high))
        {
            if (input[left] < input[right])
            {
                tmp[tmpIndex] = input[left];
                left = left + 1;
            }
            else
            {
                tmp[tmpIndex] = input[right];
                right = right + 1;
            }
            tmpIndex = tmpIndex + 1;
        }

        if (left <= middle)
        {
            while (left <= middle)
            {
                tmp[tmpIndex] = input[left];
                left = left + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        if (right <= high)
        {
            while (right <= high)
            {
                tmp[tmpIndex] = input[right];
                right = right + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        for (int i = 0; i < tmp.Length; i++)
        {
            input[low + i] = tmp[i];
        }

    }
}
