public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {  
        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove elements that are out of the current window
            if (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst();

            // Remove smaller elements as they are useless
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();

            // Add the current index
            deque.AddLast(i);

            // The first element in deque is the maximum for the current window
            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }

        return result.ToArray();
    }
}

//[1,3,1,2,0,5] and k = 3