/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates (ListNode head) {
        if (head == null) return head;
        ListNode cursor = head;
        while (cursor.next != null) {
            if (cursor.val == cursor.next.val)
                cursor.next = cursor.next?.next;
            else
                cursor = cursor.next;
        }
        return head;
    }
}