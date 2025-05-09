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
    public int FindBottomLeftValue(TreeNode root) {
        int prev = 0;
        
        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(root);

        while(q.Count > 0){
            int levelCount = q.Count;

            for(int i = 0; i < levelCount; i++){
                TreeNode cur = q.Dequeue();
                if(i == 0){
                    prev = cur.val;
                }
                if(cur.left != null) q.Enqueue(cur.left);
                if(cur.right != null) q.Enqueue(cur.right);
            }
        }

        return prev;
    }
}