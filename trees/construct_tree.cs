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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if (inorder == null || postorder == null || inorder.Length != postorder.Length) {
            return null;
        }
        return BuildTreeHelper(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
    }

    private TreeNode BuildTreeHelper(int[] inorder, int inStart, int inEnd, 
                                     int[] postorder, int postStart, int postEnd) {
        if (inStart > inEnd || postStart > postEnd) {
            return null;
        }

        // The root is the last element in the postorder traversal
        int rootValue = postorder[postEnd];
        TreeNode root = new TreeNode(rootValue);

        // Find the index of the root in inorder array
        int rootIndex = Array.IndexOf(inorder, rootValue);

        // Calculate the size of the left subtree
        int leftTreeSize = rootIndex - inStart;

        // Recursively build the left and right subtrees
        root.left = BuildTreeHelper(inorder, inStart, rootIndex - 1, 
                                    postorder, postStart, postStart + leftTreeSize - 1);
        root.right = BuildTreeHelper(inorder, rootIndex + 1, inEnd, 
                                     postorder, postStart + leftTreeSize, postEnd - 1);

        return root;
    }
}
