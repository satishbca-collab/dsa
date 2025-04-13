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
    public bool IsValidBST(TreeNode root) {
        return Helper(root, null, null);
    }

    private bool Helper(TreeNode root, int? max, int? min){
        if(root == null){
            return true;
        }

        if((max != null && root.val >= max) || (min != null && root.val <= min)){
            return false;
        }

        return Helper(root.left, root.val, min) && Helper(root.right, max, root.val);
    }
}