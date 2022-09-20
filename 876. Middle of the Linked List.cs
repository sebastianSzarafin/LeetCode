https://leetcode.com/problems/middle-of-the-linked-list/?envType=study-plan&id=level-1

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
    public ListNode MiddleNode(ListNode head) {
        int length = 0;
        ListNode p = head;
        while(p != null)
        {
            length++;
            p = p.next;
        }
        length /= 2;
        p = head;
        while(length-- > 0)
        {
            p = p.next;
        }
        return p;
    }
}
