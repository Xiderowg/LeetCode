# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def minDepth(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if(not root):
            return 0
        left = self.minDepth(root.left)
        right = self.minDepth(root.right)
        return 1+left+right if (left == 0 or right == 0) else 1+min(left, right)
