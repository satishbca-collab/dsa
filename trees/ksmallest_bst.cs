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
    private int result = 0;
    private int count = 0;
    public int KthSmallest(TreeNode root, int k) {
        Inorder(root, k);
        return result;
    }

    private void Inorder(TreeNode root, int k){
        if(root == null || result != 0){
            return;
        }
        Inorder(root.left, k);
        count++;
        if(k == count){
            result = root.val;
        }
        Inorder(root.right, k);
    }
}