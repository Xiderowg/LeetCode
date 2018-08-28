/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        int residual = 0, l1val, l2val, sum_val;
        ListNode result = new ListNode (0);
        ListNode cursor = result;
        while (l1 != null || l2 != null || residual != 0) {
            l1val = l1 != null?l1.val : 0;
            l2val = l2 != null?l2.val : 0;
            sum_val = l1val + l2val;
            if (residual != 0) {
                sum_val += residual;
                residual = 0;
            }
            if (sum_val >= 10) {
                sum_val -= 10;
                residual = 1;
            }
            cursor.next = new ListNode (sum_val);
            cursor = cursor.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return result.next;
    }
}