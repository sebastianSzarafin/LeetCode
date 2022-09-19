https://leetcode.com/problems/reverse-linked-list/

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
            if(head == null) return null;
            if(head.next == null) return head;
        
            ListNode reversed = head;
            head = head.next;
            reversed.next = null;
            while(head != null)
            {
                ListNode pom = reversed;
                reversed = head;
                head = head.next;
                reversed.next = pom;
                
            }
        
            return reversed;
        }
}
