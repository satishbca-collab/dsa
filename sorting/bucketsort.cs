using System;
using System.Collections.Generic;
using System.Linq;

public class BucketSort
{
    public static void Sort(double[] array)
    {
        if (array == null || array.Length <= 1)
            return;

        // 1. Create buckets
        int n = array.Length;
        List<double>[] buckets = new List<double>[n];
        
        for (int i = 0; i < n; i++)
        {
            buckets[i] = new List<double>();
        }
        
        // 2. Find min and max values
        double minValue = array[0];
        double maxValue = array[0];
        
        for (int i = 1; i < n; i++)
        {
            if (array[i] < minValue)
                minValue = array[i];
            else if (array[i] > maxValue)
                maxValue = array[i];
        }
        
        // 3. Scatter elements into buckets
        double range = maxValue - minValue;
        for (int i = 0; i < n; i++)
        {
            // Calculate bucket index for equally distributed values
            int bucketIndex = (int)Math.Floor((array[i] - minValue) * (n - 1) / range);
            
            // Handle edge case for max value
            bucketIndex = Math.Min(bucketIndex, n - 1);
            
            buckets[bucketIndex].Add(array[i]);
        }
        
        // 4. Sort individual buckets
        for (int i = 0; i < n; i++)
        {
            buckets[i].Sort();
        }
        
        // 5. Gather sorted elements back into original array
        int currentIndex = 0;
        for (int i = 0; i < n; i++)
        {
            foreach (var element in buckets[i])
            {
                array[currentIndex++] = element;
            }
        }
    }
    
    // Overload for integer arrays
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
            return;
            
        // Convert to double array, sort, and convert back
        double[] doubleArray = Array.ConvertAll(array, x => (double)x);
        Sort(doubleArray);
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (int)doubleArray[i];
        }
    }
    
    // Usage example
    public static void Main()
    {
        Console.WriteLine("Bucket Sort Example");
        
        // Example with double values
        double[] doubleArray = { 0.42, 0.32, 0.85, 0.33, 0.61, 0.99, 0.05, 0.23, 0.71 };
        
        Console.WriteLine("Before sorting:");
        PrintArray(doubleArray);
        
        Sort(doubleArray);
        
        Console.WriteLine("After sorting:");
        PrintArray(doubleArray);
        
        // Example with large range integers
        int[] intArray = { 5000, 15000, 8000, 12000, 3000, 18000, 1500, 9500, 25000 };
        
        Console.WriteLine("\nBefore sorting:");
        PrintArray(intArray);
        
        Sort(intArray);
        
        Console.WriteLine("After sorting:");
        PrintArray(intArray);
    }
    
    private static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}

