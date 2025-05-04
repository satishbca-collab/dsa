/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 // https://leetcode.com/problems/path-sum/description/
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        // Base case: if the root is null, no path exists
        if (root == null) return false;

        // Check if it's a leaf node and the targetSum equals its value
        if (root.left == null && root.right == null && targetSum == root.val) {
            return true;
        }

        // Recursively check for path in the left or right subtree
        int remainingSum = targetSum - root.val;
        return HasPathSum(root.left, remainingSum) || HasPathSum(root.right, remainingSum);
    }
}