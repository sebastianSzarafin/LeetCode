https://leetcode.com/problems/remove-duplicates-from-sorted-list/

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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode p = head;
        while(p != null)
        {
            while(p.next != null && p.val == p.next.val)
            {
                ListNode toDelete = p.next;
                p.next = p.next.next;
                toDelete = null;
            }
            if(p.next == null || p.val != p.next.val) p = p.next;
        }
        return head;
    }
}
