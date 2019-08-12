public class Solution {
    public int SingleNumber (int[] nums) {
        int cur = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            cur ^= nums[i];
        }
        return cur;
    }
}