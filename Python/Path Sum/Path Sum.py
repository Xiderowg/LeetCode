# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def hasPathSum(self, root, sum):
        """
        :type root: TreeNode
        :type sum: int
        :rtype: bool
        """
        if(not root):
            return False
        if(sum == root.val not root.left and not root.right):
            return True
        sum -= root.val
        leftHas = self.hasPathSum(root.left, sum)
        rightHas = self.hasPathSum(root.right, sum)
        return leftHas or rightHas
