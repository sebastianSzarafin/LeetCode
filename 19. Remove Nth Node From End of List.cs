https://leetcode.com/problems/remove-nth-node-from-end-of-list/?envType=study-plan&id=algorithm-i

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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int length = 0;
        ListNode p = head, prev = head;
        while(p != null)
        {
            p = p.next;
            length++;
        }
        length -= n;
        p = head;
        if(length == 0)
        {
            head = head.next;
            prev = null;
            return head;
        }
        while(length-- > 0)
        {
            prev = p;
            p = p.next;
        }
        prev.next = p.next;
        p = null;
        return head;
    }
}
