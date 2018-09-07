# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def levelOrder(self, root):
        """
        :type root: TreeNode
        :rtype: List[List[int]]
        """
        if (not root):
            return []
        queue = []
        levels_vals = []
        queue.append(root)
        while (len(queue) > 0):
            levels_vals.append(self.helper(queue))
        return levels_vals

    def helper(self, queue):
        node_count = len(queue)
        level_vals = []
        for i in range(node_count):
            node = queue.pop(0)
            if (node.left):
                queue.append(node.left)
            if (node.right):
                queue.append(node.right)
            level_vals.append(node.val)
        return level_vals
