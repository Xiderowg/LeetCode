# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def mergeTwoLists(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        l1_val = []
        l2_val = []
        while l1:
            l1_val.append(l1.val)
            l1 = l1.next
        while l2:
            l2_val.append(l2.val)
            l2 = l2.next
        val_list = sorted(l1_val + l2_val)
        
        result = head = ListNode(0)
        for i in val_list:
            head.next = ListNode(i)
            head = head.next
        head.next = None

        return result.next