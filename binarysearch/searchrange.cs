public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        if(n == 0){
            return [-1,-1];
        }

        int l = 0, r = n-1;
        int mid = 0;
        while(l <= r){
            mid = l + (r-l)/2;
            if(nums[mid] == target){
                break;
            }
            else if(nums[mid] > target){
                r = mid-1;
            }
            else {
                l = mid+1
            }
        }
        if(nums[mid] != target){
            return [-1,-1];
        }

        int left = mid, right = mid;
        while(left >= 0 && nums[left] == target){
            left--;
        }
        while(right < n && nums[right] == target){
            right++;
        }
        return [left+1, right-1];
    }
}