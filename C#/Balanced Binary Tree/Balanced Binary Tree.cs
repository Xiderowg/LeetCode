/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private bool isBalanced = true;

    public bool IsBalanced (TreeNode root) {
        if (root == null || (root.left == null && root.right == null)) return true;
        GetDepth (root);
        return isBalanced;
    }

    private int GetDepth (TreeNode node) {
        if (node == null) return 0;
        int leftDepth = GetDepth (node.left);
        int rightDepth = GetDepth (node.right);
        if (Math.Abs (leftDepth - rightDepth) > 1)
            isBalanced = false;
        return 1 + Math.Max (leftDepth, rightDepth);
    }
}