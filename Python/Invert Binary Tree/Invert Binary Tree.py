# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None


class Solution:
    def invertTree(self, root: TreeNode) -> TreeNode:
        self.invert(root)
        return root

    def invert(self, node: TreeNode):
        if(node == None):
            return
        tmp = node.left
        node.left = node.right
        node.right = tmp
        self.invert(node.left)
        self.invert(node.right)
