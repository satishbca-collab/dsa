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
 // https://leetcode.com/problems/path-sum-ii/?ref=bosscoder-academy-2.ghost.io
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> result = new List<IList<int>>();

        FindPaths(root, targetSum, result, new List<int>());

        return result;
    }

    private void FindPaths(TreeNode node, int targetSum, IList<IList<int>> result, IList<int> path){
        if (node == null) return;

        // Add current node value to the path
        path.Add(node.val);

        // Check if this is a leaf node and the path sum equals targetSum
        if (node.left == null && node.right == null && targetSum == node.val) {
            result.Add(new List<int>(path)); // Add a copy of the path to the result
        }

        // Recursively search the left and right subtrees
        FindPaths(node.left, targetSum - node.val, result, path);
        FindPaths(node.right, targetSum - node.val, result, path);

        // Backtrack: remove the current node value from the path
        path.RemoveAt(path.Count - 1);
    }
}