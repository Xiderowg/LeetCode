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
    public IList<IList<int>> LevelOrderBottom (TreeNode root) {
        List<IList<int>> levels = new List<IList<int>> ();

        if (root == null) {
            return levels;
        }

        Queue<TreeNode> nodesToProcess =
            new Queue<TreeNode> ();

        nodesToProcess.Enqueue (root);

        while (nodesToProcess.Count != 0) {
            levels.Add (ProcessLevel (nodesToProcess));
        }

        Reverse (levels);

        return levels;
    }

    private void Reverse (List<IList<int>> levels) {
        int mid = (levels.Count - 1) / 2;

        for (int left = 0, right = levels.Count - 1; left <= mid; left++, right--) {
            IList<int> temp = levels[left];
            levels[left] = levels[right];
            levels[right] = temp;
        }
    }

    private List<int> ProcessLevel (Queue<TreeNode> nodesToProcess) {
        int levelCount = nodesToProcess.Count;
        List<int> level = new List<int> (levelCount);

        for (int i = 0; i < levelCount; i++) {
            TreeNode curNode = nodesToProcess.Dequeue ();

            if (curNode.left != null) {
                nodesToProcess.Enqueue (curNode.left);
            }

            if (curNode.right != null) {
                nodesToProcess.Enqueue (curNode.right);
            }

            level.Add (curNode.val);
        }

        return level;
    }
}