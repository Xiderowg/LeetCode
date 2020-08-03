# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def flatten(self, root: TreeNode) -> None:
        """
        Do not return anything, modify root in-place instead.
        """
        node_list=[]
        self.pre_order(root,node_list)
        cur=root
        for i in range(1,len(node_list)):
            cur.right=node_list[i]
            cur.left=None
            cur=cur.right
    
    def pre_order(self,node:TreeNode,l:list)->None:
        if node is None:
            return
        l.append(node)
        self.pre_order(node.left,l)
        self.pre_order(node.right,l)
            