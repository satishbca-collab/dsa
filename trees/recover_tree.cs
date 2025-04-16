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
    private TreeNode first = null;
    private TreeNode second = null;
    private TreeNode prev = new TreeNode(int.MinValue);

    public void RecoverTree(TreeNode root) {
        // Step 1: Perform in-order traversal to identify the swapped nodes
        InOrderTraversal(root);

        // Step 2: Swap the values of the two incorrect nodes
        if (first != null && second != null)
        {
            int temp = first.val;
            first.val = second.val;
            second.val = temp;
        }
    }

    private void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        // Traverse left subtree
        InOrderTraversal(node.left);

        // Identify nodes that are out of order
        if (prev.val > node.val)
        {
            if (first == null)
            {
                first = prev; // First incorrect node
            }
            second = node; // Second incorrect node
        }

        prev = node; // Update previous node

        // Traverse right subtree
        InOrderTraversal(node.right);
    }
}