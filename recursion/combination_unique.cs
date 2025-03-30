public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates); // Optional: Helps to optimize the backtracking
        GenerateCombinations(candidates, target, 0, new List<int>(), result);
        return result;
        
    }

    private static void GenerateCombinations(int[] candidates, int target, int index, List<int> current, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        if (target < 0 || index == candidates.Length)
        {
            return;
        }

        // Include the current candidate and move to the next index
        current.Add(candidates[index]);
        GenerateCombinations(candidates, target - candidates[index], index + 1, current, result);
        current.RemoveAt(current.Count - 1); // Backtrack

        // Skip duplicates
        while (index + 1 < candidates.Length && candidates[index] == candidates[index + 1])
            index++;

        // Exclude the current candidate and move to the next index
        GenerateCombinations(candidates, target, index + 1, current, result);
    }
}