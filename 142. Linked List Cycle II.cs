https://leetcode.com/problems/linked-list-cycle-ii/?envType=study-plan&id=level-1

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
    public ListNode DetectCycle(ListNode head) {
        ListNode p = head;
        List<ListNode> road = new List<ListNode>();
        while(p != null)
        {
            foreach(var node in road)
            {
                if(node == p) return p;
            }
            road.Add(p);
            p = p.next;
        }
        return null;
    }
}
