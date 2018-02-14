using System;

public class BubbleSort
{
    public static int[] Sort(int[] inputArray)
    {
        int[] arrayCopy = new int[inputArray.Length];
        Array.Copy(inputArray, arrayCopy, inputArray.Length);
        inputArray = arrayCopy;

        for (int p = 0; p <= inputArray.Length - 2; p++)
        {
            for (int i = 0; i <= inputArray.Length - 2; i++)
            {
                if (inputArray[i] > inputArray[i + 1])
                {
                    int t = inputArray[i + 1];
                    inputArray[i + 1] = inputArray[i];
                    inputArray[i] = t;
                }
            }
        }
        return inputArray;
    }
}
