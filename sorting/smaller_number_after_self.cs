public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        int[] count = new int[nums.Length];
        int[] indexes = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            indexes[i] = i;
            count[i] = 0;
        }
        mergesort(nums, 0, nums.Length-1, indexes, count);
        return count;
    }

    private void mergesort(int[] nums, int l, int r, int[] indexes, int[] count){
        if(l >= r){
            return;
        }

        int mid = l + (r-l)/2;
        mergesort(nums, l, mid, indexes, count);
        mergesort(nums, mid+1, r, indexes, count);
        merge(nums, l, mid, r, indexes, count);
    }

    private void merge(int[] nums, int l, int mid, int r, int[] indexes, int[] count){
        int i = mid, j = r, k = r-l;
        int[] temp = new int[r-l+1];

        while(i >= l && j > mid){
            if(nums[indexes[i]] <= nums[indexes[j]]){
                temp[k--] = indexes[j--];
            }
            else {
                count[indexes[i]] += j - mid;
                temp[k--] = indexes[i--];
            }
        }
        while(i >= l){
            temp[k--] = indexes[i--];
        }
        while(j > mid){
            temp[k--] = indexes[j--];
        }

        for(int a = l; a <= r; a++){
            indexes[a] = temp[a-l];
        }
    }
}