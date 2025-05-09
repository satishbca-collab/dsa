/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || root == p || root == q) {
            return root; // Base case: If the root is null, there's no ancestor
        }

            TreeNode left =  LowestCommonAncestor(root.left, p, q);

            TreeNode right = LowestCommonAncestor(root.right, p, q);

        // Otherwise, the current root is the LCA
        return (left != null && right != null) ? root : left != null ? left : right;
    }
}