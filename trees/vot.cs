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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var map = new SortedDictionary<int, List<int>>();
        var queue = new Queue<(TreeNode node, int col)>();
        queue.Enqueue((root, 0));

        while (queue.Count > 0) {
            var levelList = new List<(int val, int col)>();
            int size = queue.Count;

            for (int i = 0; i < size; i++) {
                var (node, col) = queue.Dequeue();
                levelList.Add((node.val, col));
                if (node.left != null) queue.Enqueue((node.left, col - 1));
                if (node.right != null) queue.Enqueue((node.right, col + 1));
            }

            // Sort levelList based on value (then on column if needed)
            levelList.Sort((a, b) => a.val.CompareTo(b.val));

            foreach (var (val, col) in levelList) {
                if (!map.ContainsKey(col))
                    map[col] = new List<int>();
                map[col].Add(val);
            }
        }

        var result = new List<IList<int>>();
        foreach (var kvp in map) {
            result.Add(kvp.Value);
        }
        return result;
    }
}