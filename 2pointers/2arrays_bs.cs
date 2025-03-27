using System;
using System.Collections.Generic;

public class Solution {
    public List<(int, int)> FindPairsWithBinarySearch(int[] arr1, int[] arr2, int target) {
        List<(int, int)> result = new List<(int, int)>();

        // Sort the second array to perform binary search
        Array.Sort(arr2);

        // Iterate through each element in the first array
        foreach (int num in arr1) {
            int complement = target - num;

            // Perform binary search for the complement in the sorted second array
            if (BinarySearch(arr2, complement)) {
                result.Add((num, complement));
            }
        }

        return result;
    }

    // Helper function for binary search
    private bool BinarySearch(int[] arr, int target) {
        int left = 0, right = arr.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) {
                return true;
            } else if (arr[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return false;
    }
}
