public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        GenerateSubsets(nums, 0, new List<int>(), result);
        return result;
    }

    private static void GenerateSubsets(int[] nums, int index, List<int> current, IList<IList<int>> result)
    {
        if (index == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        // Decision to include nums[index]
        current.Add(nums[index]);
        GenerateSubsets(nums, index + 1, current, result);

        // Decision to not include nums[index]
        current.RemoveAt(current.Count - 1);
        GenerateSubsets(nums, index + 1, current, result);
    }
}

/**
TC: O(2^n)
SC: O(2^n * n)
**/

