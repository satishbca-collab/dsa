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
    public ListNode MergeKLists(ListNode[] lists) {
        var pq = new PriorityQueue<ListNode, int>(); // Min-heap
        
        foreach (var list in lists) {
            if (list != null) {
                pq.Enqueue(list, list.val); // Push all head nodes
            }
        }

        ListNode dummy = new ListNode(-1);
        ListNode tail = dummy;

        while (pq.Count > 0) {
            ListNode node = pq.Dequeue();
            tail.next = node;
            tail = node;

            if (node.next != null) {
                pq.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}