//https://leetcode.com/problems/trapping-rain-water/
public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0) return 0; // No blocks, no water!

        int left = 0, right = n - 1; // Two pointers
        int leftMax = 0, rightMax = 0; // Track maximum heights
        int totalWater = 0;

        while (left < right) {
            if (height[left] < height[right]) {
                // Left side is shorter
                if (height[left] >= leftMax) {
                    leftMax = height[left]; // Update left max
                } else {
                    totalWater += leftMax - height[left]; // Calculate water
                }
                left++; // Move left pointer
            } else {
                // Right side is shorter
                if (height[right] >= rightMax) {
                    rightMax = height[right]; // Update right max
                } else {
                    totalWater += rightMax - height[right]; // Calculate water
                }
                right--; // Move right pointer
            }
        }

        return totalWater;
    }
}