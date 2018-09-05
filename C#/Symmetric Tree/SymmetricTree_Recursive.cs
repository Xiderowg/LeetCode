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
    public bool IsSymmetric (TreeNode root) {
        if (root == null) return true;
        return Helper (root.left, root.right);
    }

    public bool Helper (TreeNode left, TreeNode right) {
        if (left == null && right == null) return true;
        if (left == null && right != null || left != null && right == null || left.val != right.val) return false;
        return Helper (left.left, right.right) && Helper (left.right, right.left);
    }
}