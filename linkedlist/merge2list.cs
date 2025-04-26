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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode cur1 = list1, cur2 = list2;
        // Create a dummy node to simplify the merging process
        ListNode dummy = new ListNode();
        ListNode result = dummy;

        while(cur1 != null && cur2 != null){
            if(cur1.val > cur2.val){
                result.next = cur2;
                cur2 = cur2.next;
            }
            else {
                result.next = cur1;
                cur1 = cur1.next;
            }
            result = result.next;
        }

        // while(cur1 != null){
        //     result.next = cur1;
        //     cur1 = cur1.next;
        //     result = result.next;
        // }

        // while(cur2 != null){
        //     result.next = cur2;
        //     cur2 = cur2.next;
        //     result = result.next;
        // }

        // Append the remaining nodes of list1 or list2
        result.next = (cur1 != null) ? cur1 : cur2;


        return dummy.next;
    }
}