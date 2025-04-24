// User function Template for Java

class Solution {
    public Node sortedArrayToBST(int[] nums) {
        // Code here
        return constructBST(nums, 0, nums.length - 1);
    }
    
    // Helper function to construct BST recursively
    private Node constructBST(int[] nums, int start, int end) {
        // Base case: if start index exceeds end index
        if (start > end) {
            return null;
        }
    
        // Find the middle element to make it the root
        int mid = start + (end - start) / 2;
        Node root = new Node(nums[mid]);
    
        // Recursively construct left and right subtrees
        root.left = constructBST(nums, start, mid - 1);
        root.right = constructBST(nums, mid + 1, end);
    
        return root;
    }
}