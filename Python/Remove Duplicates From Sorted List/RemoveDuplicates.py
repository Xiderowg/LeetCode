# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None


class Solution:
    def deleteDuplicates(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        if (head):
            cursor = head
            while (cursor.next):
                if (cursor.next.val != cursor.val):
                    cursor = cursor.next
                else:
                    cursor.next = cursor.next.next
        return head