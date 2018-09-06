# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def levelOrderBottom(self, root):
        """
        :type root: TreeNode
        :rtype: List[List[int]]
        """
        if (not root):
            return []

        result = []

        queue = []
        queue.append(root)
        while (len(queue) > 0):
            result.append(self.helper(queue))

        result = result[::-1]
        return result

    def helper(self, queue):
        node_count = len(queue)

        level_vals = []

        while (node_count > 0):
            node = queue.pop(0)
            if (node.left):
                queue.append(node.left)
            if (node.right):
                queue.append(node.right)

            level_vals.append(node.val)
            node_count -= 1

        return level_vals
