//https://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/


// User function Template for Java

/* A Binary Tree node

class Node {
    int data;
    Node left, right;
   Node(int item)    {
        data = item;
        left = right = null;
    }
} */
class Solution {
    // Return a list containing the inorder traversal of the given tree
    ArrayList<Integer> inOrder(Node root) {
        // Code
        ArrayList<Integer> result = new ArrayList<>();
        Stack<Node> st = new Stack<>();
        
        Node cur = root;
        
        while(cur != null || !st.empty()){
            while(cur != null){
                st.push(cur);
                cur = cur.left;
            }
            
            Node temp = st.pop();
            result.add(temp.data);
            cur = temp.right;
        }
        
        return result;
    }
}