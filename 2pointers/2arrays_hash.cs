public List<(int, int)> FindPairsWithSum(int[] arr1, int[] arr2, int target) {
    HashSet<int> elements = new HashSet<int>();
    List<(int, int)> result = new List<(int, int)>();

    // Add all elements from the first array to the hash set
    foreach (int num in arr1) {
        elements.Add(num);
    }

    // Check for pairs with the given sum in the second array
    foreach (int num in arr2) {
        int complement = target - num;
        if (elements.Contains(complement)) {
            result.Add((complement, num));
        }
    }

    return result;
}
