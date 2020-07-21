public class Solution {
    public bool ContainsDuplicate (int[] nums) {
        if (nums.Length <= 1) return false;
        HashSet<int> numSet = new HashSet<int> ();
        foreach (var num in nums) {
            if (numSet.Contains (num)) return true;
            numSet.Add (num);
        }
        return false;
    }
}