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
        if (head == null || head.next == null) return head;
        //int originVal=head.val;
        ListNode preCursor = head;
        ListNode cursor = new ListNode (head.val);
        cursor.next = head.next;
        bool trimHead = head.next.val == head.val?true : false;
        while (cursor.next != null) {
            if (cursor.next.val != cursor.val) {
                if (cursor.next.next == null || cursor.next.val != cursor.next.next.val) {
                    preCursor.next = cursor.next;
                    preCursor = preCursor.next;
                    if (trimHead) {
                        head = preCursor;
                        trimHead = false;
                    }
                }
            }
            cursor = cursor.next;
        }
        if (trimHead) return null;
        preCursor.next = null;
        return head;
    }
}