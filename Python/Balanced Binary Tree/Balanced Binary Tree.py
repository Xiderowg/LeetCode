# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def isBalanced(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        if(not root):
            return True
        depth = self.helper(root)
        if(depth == -1):
            return False
        return True

    def helper(self, node):
        if(not node):
            return 0
        left = self.helper(node.left)
        right = self.helper(node.right)
        if(left == -1 or right == -1 or abs(left-right) > 1):
            return -1
        return 1+max(left, right)
