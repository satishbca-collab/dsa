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
    public ListNode MiddleNode(ListNode Head) {
        if (Head == null)
        {
            Console.WriteLine("The list is empty.");
            return Head;
        }

        ListNode slow = Head;
        ListNode fast = Head;

        // Move 'fast' by two steps and 'slow' by one step
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}