public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
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

        // Decision to include candidates[index]
        current.Add(candidates[index]);
        GenerateCombinations(candidates, target - candidates[index], index, current, result);

        // Decision to not include candidates[index]
        current.RemoveAt(current.Count - 1);
        GenerateCombinations(candidates, target, index + 1, current, result);
    }
}

/**
TC: O(2^(target / minValue)) max decisions is target/minValue
SC: O(target / minValue) for the call stack, O(k) for result storage.
**/