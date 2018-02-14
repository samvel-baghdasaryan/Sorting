using System;

public class HeapSort
{

    public static int[] Sort(int[] array)
    {
        int[] arrayCopy = new int[array.Length];
        Array.Copy(array, arrayCopy, array.Length);
        array = arrayCopy;

        int heapSize = array.Length;

        buildMaxHeap(array);

        for (int i = heapSize - 1; i >= 1; i--)
        {
            swap(array, i, 0);
            heapSize--;
            sink(array, heapSize, 0);
        }
        return array;
    }

    private static void buildMaxHeap(int[] array)
    {
        int heapSize = array.Length;

        for (int i = (heapSize / 2) - 1; i >= 0; i--)
        {
            sink(array, heapSize, i);
        }
    }

    private static void sink(int[] array, int heapSize, int toSinkPos)
    {
        if (getLeftKidPos(toSinkPos) >= heapSize)
        {
            // No left kid => no kid at all
            return;
        }


        int largestKidPos;
        bool leftIsLargest;

        if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
        {
            largestKidPos = getLeftKidPos(toSinkPos);
            leftIsLargest = true;
        }
        else
        {
            largestKidPos = getRightKidPos(toSinkPos);
            leftIsLargest = false;
        }



        if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
        {
            swap(array, toSinkPos, largestKidPos);

            if (leftIsLargest)
            {
                sink(array, heapSize, getLeftKidPos(toSinkPos));

            }
            else
            {
                sink(array, heapSize, getRightKidPos(toSinkPos));
            }
        }

    }

    private static void swap(int[] array, int pos0, int pos1)
    {
        int tmpVal = array[pos0];
        array[pos0] = array[pos1];
        array[pos1] = tmpVal;
    }

    private static int getLeftKidPos(int parentPos)
    {
        return (2 * (parentPos + 1)) - 1;
    }

    private static int getRightKidPos(int parentPos)
    {
        return 2 * (parentPos + 1);
    }

}