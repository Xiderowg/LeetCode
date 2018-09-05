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
    public int MaxDepth (TreeNode root) {
        if (root == null) return 0;
        return Helper (root, 1);
    }

    private int Helper (TreeNode node, int depth) {
        if (node == null) return --depth;
        int left = Helper (node.left, ++depth);
        int right = Helper (node.right, depth);
        return left > right?left : right;
    }
}