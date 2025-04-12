public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length-1;
        while(i < j){
            int sum = numbers[i] + numbers[j];
            if(sum == target){
                return [i+1, j+1];
            }
            else if(sum < target){
                i++;
            }
            else {
                j--;
            }
        }
        return [-1,-1];
    }
}