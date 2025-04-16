class Solution {
    // returns the inorder successor of the Node x in BST (rooted at 'root')
    public int inorderSuccessor(Node root, Node target) {
        // add code here.
        if (target.right != null)
        {
            // Case: The target node has a right subtree
            return FindMin(target.right);
        }
        Node successor = null;

        while (root != null)
        {
            if (target.data < root.data)
            {
                successor = root; // Potential successor
                root = root.left;
            }
            else
            {
                root = root.right;
            }
        }

        return successor != null ?successor.data:-1;
    }
    
    private int FindMin(Node node)
    {
        while (node.left != null)
        {
            node = node.left;
        }
        return node.data;
    }
}