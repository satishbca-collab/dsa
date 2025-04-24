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
 // https://leetcode.com/problems/binary-tree-right-side-view/
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int levelSize = queue.Count;

            // Traverse nodes at the current level
            for (int i = 0; i < levelSize; i++) {
                TreeNode currentNode = queue.Dequeue();

                // Add the rightmost node of this level to the result
                if (i == levelSize - 1) {
                    result.Add(currentNode.val);
                }

                // Enqueue child nodes for the next level
                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }
        }

        return result;
    }
}