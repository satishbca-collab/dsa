public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums); // Sort to handle duplicates
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
        
        // Skip duplicates
        while (index + 1 < nums.Length && nums[index] == nums[index + 1])
            index++;
            
        GenerateSubsets(nums, index + 1, current, result);
    }
}