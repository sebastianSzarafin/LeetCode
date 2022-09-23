https://leetcode.com/problems/linked-list-cycle/?envType=study-plan&id=data-structure-i

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
        if(head == null || head.next == null) return false;
        ListNode slower = head;
        ListNode faster = head.next;
        while(slower != faster)
        {
            slower = slower.next;
            if(faster != null) faster = faster.next;
            if(faster != null) faster = faster.next;
            if(slower == null || faster == null) return false;
        }
        return true;
    }
}
