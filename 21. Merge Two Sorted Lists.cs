https://leetcode.com/problems/merge-two-sorted-lists/

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
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        
        ListNode mergedList;
        if(list1.val > list2.val)
        {
            mergedList = list2;
            list2 = list2.next;
            mergedList.next = null;
        }
        else
        {
            mergedList = list1;
            list1 = list1.next;
            mergedList.next = null;
        }
        
        ListNode p = mergedList;
        while(list1 != null && list2 != null)
        {
            if(list1.val > list2.val) 
            {
                p.next = list2;
                list2 = list2.next;
                p.next.next = null;
            }
            else
            {
                p.next = list1;
                list1 = list1.next;
                p.next.next = null;
            }
            p = p.next;
        }
        
        if(list1 != null) p.next = list1;
        if(list2 != null) p.next = list2;
        
        return mergedList;
    }
}
