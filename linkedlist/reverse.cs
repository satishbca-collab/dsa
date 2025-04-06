/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode previous = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.next;  // Store the next node
            current.next = previous; // Reverse the pointer
            previous = current;      // Move 'previous' forward
            current = next;          // Move 'current' forward
        }

        head = previous; // Update the head to the new front

        return head;
    }
}