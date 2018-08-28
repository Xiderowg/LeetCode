# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None


class Solution:
    def addTwoNumbers(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        result = ListNode(None)
        cursor = result
        residual = 0
        while (l1 != None or l2 != None or residual != 0):
            l1val = l1.val if l1 != None else 0
            l2val = l2.val if l2 != None else 0
            sumval = l1val + l2val
            if (residual != 0):
                sumval += residual
                residual = 0
            if (sumval >= 10):
                sumval -= 10
                residual = 1
            cursor.next = ListNode(sumval)
            cursor = cursor.next
            l1 = l1.next if l1 != None else None
            l2 = l2.next if l2 != None else None
        return result.next