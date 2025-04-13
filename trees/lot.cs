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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();

        if (root != null) {
            queue.Enqueue(root);
        }

        while (queue.Count > 0) {
            var level = new List<int>();
            for (int i = 0, size = queue.Count; i < size; i++) {
                var current = queue.Dequeue();
                level.Add(current.val);

                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }
            result.Add(level);
        }

        return result;
    }
}