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
    public TreeNode SortedArrayToBST (int[] nums) {
        if (nums.Length < 1) return null;
        TreeNode head = Helper (nums, 0, nums.Length - 1);
        return head;
    }

    private TreeNode Helper (int[] nums, int low, int high) {
        if (low > high) return null;
        int mid = (low + high) / 2;
        TreeNode node = new TreeNode (nums[mid]);
        node.left = Helper (nums, low, mid - 1);
        node.right = Helper (nums, mid + 1, high);
        return node;
    }
}