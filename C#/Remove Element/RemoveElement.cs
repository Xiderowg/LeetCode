public class Solution {
    public int RemoveElement (int[] nums, int val) {
        if (nums.Length == 0)
            return 0;
        int ptr = 0;
        for (int j = 0; j < nums.Length; j++) {
            if (ptr != j) {
                nums[ptr] = nums[j];
            }
            if (nums[j] != val) {
                ptr++;
            }
        }
        return ptr;
    }
}