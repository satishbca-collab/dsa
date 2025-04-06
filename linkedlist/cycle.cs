/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;           // Move slow pointer one step
            fast = fast.next.next;      // Move fast pointer two steps

            if (slow == fast)
            {
                return true;            // Cycle detected
            }
        }

        return false;                   // No cycle detected
    }
}