# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None


class Solution:
    def reverseList(self, head: ListNode) -> ListNode:
        pre, dmp, cur = None, None, head
        while(cur):
            dmp = ListNode(cur.val)
            dmp.next = pre
            pre = dmp
            cur = cur.next
        return dmp
