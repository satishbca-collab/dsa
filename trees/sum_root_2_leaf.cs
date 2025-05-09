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
public class Solution {
    public int SumNumbers(TreeNode root) {
        return Helper(root, 0);
    }

    private int Helper(TreeNode root, int sum){
        if(root == null){
            return 0;
        }

        int currentSum = sum * 10 + root.val;

        if(root.left == null && root.right == null){
            return currentSum;
        }

        return Helper(root.left, currentSum) + Helper(root.right, currentSum);
    }
}