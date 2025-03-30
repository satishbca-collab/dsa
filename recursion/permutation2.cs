public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        helper(nums, result, new List<int>(), new bool[nums.Length]);
        return result;
    }

    private void helper(int[] nums, IList<IList<int>> result, IList<int> current, bool[] visited){
        if(current.Count == nums.Length){
            result.Add(new List<int>(current));
        }

        for(int i = 0; i < nums.Length; i++){
            if(visited[i]){
                continue;
            }

            current.Add(nums[i]);
            visited[i] = true;
            helper(nums, result, current, visited);
            current.RemoveAt(current.Count-1);
            visited[i] = false;
            while(i < nums.Length - 1 && nums[i] == nums[i+1]){
                i++;
            }
        }
    }
}