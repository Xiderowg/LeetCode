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
    public IList<IList<int>> LevelOrder (TreeNode root) {
        IList<IList<int>> levelsVals = new List<IList<int>> ();
        if (root == null) return levelsVals;

        Queue<TreeNode> queue = new Queue<TreeNode> ();
        queue.Enqueue (root);
        while (queue.Count > 0) {
            levelsVals.Add (Helper (ref queue));
        }

        return levelsVals;
    }

    private IList<int> Helper (ref Queue<TreeNode> queue) {
        IList<int> levelVals = new List<int> ();
        int nodeCount = queue.Count;
        for (int i = 0; i < nodeCount; i++) {
            TreeNode node = queue.Dequeue ();
            levelVals.Add (node.val);
            if (node.left != null) queue.Enqueue (node.left);
            if (node.right != null) queue.Enqueue (node.right);
        }
        return levelVals;
    }
}