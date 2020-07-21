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
    public bool HasPathSum (TreeNode root, int sum) {
        if (root == null) return false;
        if (sum == root.val && root.left == null && root.right == null) return true;
        sum -= root.val;
        bool leftHas = HasPathSum (root.left, sum);
        bool rightHas = HasPathSum (root.right, sum);
        return leftHas || rightHas;
    }
}