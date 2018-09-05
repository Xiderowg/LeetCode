# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def isSymmetric(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        if not root:
            return True
        return self.Helper(root.left, root.right)

    def Helper(self, left, right):
        if (not left and not right):
            return True
        if ((not left and right) or (not right and left)):
            return False
        return self.Helper(left.left, right.right) and self.Helper(
            left.right, right.left)
