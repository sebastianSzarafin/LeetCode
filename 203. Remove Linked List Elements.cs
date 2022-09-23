https://leetcode.com/problems/remove-linked-list-elements/?envType=study-plan&id=data-structure-i

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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null) return head;
        ListNode p = head;
        while(p != null && p.val == val)
        {
            head = head.next;
            p = null;
            p = head;
        }
        ListNode prev = head;
        p = head;
        while(p != null)
        {
            if(p.val == val)
            {
                prev.next = p.next;
                p = null;
                p = prev.next;
                
            }
            else 
            {
                prev = p;
                p = p.next;
            }
        }
        return head;
    }
}
