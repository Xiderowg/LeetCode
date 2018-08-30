public class Solution {
    public int SearchInsert (int[] nums, int target) {
        if (nums.Length == 0 || target < nums[0])
            return 0;
        if (target > nums[nums.Length - 1])
            return nums.Length;
        int c, cn;
        for (int i = 0; i < nums.Length - 1; i++) {
            c = nums[i];
            cn = nums[i + 1];
            if (c == target)
                return i;
            else if ((target < cn && target > c) || cn == target)
                return i + 1;
        }
        return nums.Length - 1;
    }
}