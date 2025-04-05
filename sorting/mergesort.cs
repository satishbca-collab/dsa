using System;

class MergeSort
{
    public static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[middle + 1 + j];

        int iIndex = 0, jIndex = 0;
        int kIndex = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[kIndex] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[kIndex] = rightArray[jIndex];
                jIndex++;
            }
            kIndex++;
        }

        while (iIndex < n1)
        {
            array[kIndex] = leftArray[iIndex];
            iIndex++;
            kIndex++;
        }

        while (jIndex < n2)
        {
            array[kIndex] = rightArray[jIndex];
            jIndex++;
            kIndex++;
        }
    }

    public static void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            MergeSortRecursive(array, left, middle);
            MergeSortRecursive(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        
        Console.WriteLine("Unsorted Array:");
        Console.WriteLine(string.Join(", ", array));

        MergeSortRecursive(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(", ", array));
    }
}
