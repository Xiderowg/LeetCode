/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists (ListNode l1, ListNode l2) {
        ListNode head = new ListNode (0);
        ListNode curr = head;
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                curr.next = l1;
                l1 = l1.next;
            } else {
                curr.next = l2;
                l2 = l2.next;
            }
            curr=curr.next;
        }
        if (l1 != null) {
            curr.next = l1;
            l1 = l1.next;
        } else {
            if (l2 != null) {
                curr.next = l2;
                l2 = l2.next;
            } else {
                curr.next = null;
            }
        }
        return head.next;
    }
}