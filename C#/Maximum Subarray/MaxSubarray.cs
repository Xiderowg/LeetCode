public class Solution {
    public int MaxSubArray (int[] nums) {
        int[] sub = new int[nums.Length];
        int max = nums[0];
        sub[0] = max;
        for (int i = 1; i < nums.Length; i++) {
            sub[i] = nums[i] + sub[i - 1] > nums[i] ? nums[i] + sub[i - 1] : nums[i];
            if (max < sub[i])
                max = sub[i];
        }
        return max;
    }
}