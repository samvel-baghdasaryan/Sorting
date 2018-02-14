using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class InsertionSort
{
    public static int[] Sort(int[] inputArray)
    {
        int[] arrayCopy = new int[inputArray.Length];
        Array.Copy(inputArray, arrayCopy, inputArray.Length);
        inputArray = arrayCopy;

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray;
    }

}