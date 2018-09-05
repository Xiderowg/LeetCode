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
        Queue<TreeNode> treeQueque = new Queue<TreeNode> ();
        treeQueque.Enqueue (root);
        treeQueque.Enqueue (root);
        while (treeQueque.Count > 0) {
            TreeNode right = treeQueque.Dequeue ();
            TreeNode left = treeQueque.Dequeue ();
            if (left == null && right != null || left != null && right == null || left?.val != right?.val) return false;
            if (left != null && right != null) {
                treeQueque.Enqueue (left.left);
                treeQueque.Enqueue (right.right);
                treeQueque.Enqueue (left.right);
                treeQueque.Enqueue (right.left);
            }
        }
        return true;
    }
}