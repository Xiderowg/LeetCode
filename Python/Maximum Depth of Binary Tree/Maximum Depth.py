# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def maxDepth(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        return self.Helper(root, root, 1)

    def Helper(self, left, right, depth):
        if (not left and not right):
            return depth - 1
        return max(
            self.Helper(left.left, left.right, depth + 1) if left else depth,
            self.Helper(right.right, right.left, depth + 1)
            if right else depth)
