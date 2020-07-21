public class Solution {
    public bool ContainsNearbyDuplicate (int[] nums, int k) {
        if (nums.Length <= 1) return false;
        Dictionary<int, int> dict = new Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (dict.Keys.Contains (nums[i]) && i - dict[nums[i]] <= k) return true;
            if (dict.Keys.Contains (nums[i])) dict[nums[i]] = i;
            else dict.Add (nums[i], i);
        }
        return false;
    }

    // Time limit exceeded
    public bool ContainsNearbyDuplicate_Tmp (int[] nums, int k) {
        if (nums.Length <= 1) return false;
        int i = 0, max = 0;
        do {
            max = i + k > nums.Length - 1 ? nums.Length - 1 : i + k;
            for (int j = i + 1; j <= max; j++) {
                if (nums[j] == nums[i]) return true;
            }
            i++;
        } while (i < nums.Length - 1);
        return false;
    }
}