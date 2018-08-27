public class Solution {
    public int RemoveDuplicates (int[] nums) {
        int ptr = 0;
        for (int j = 1; j < nums.Length; j++) {
            if (nums[ptr] != nums[j]) {
                ptr += 1;
                nums[ptr] = nums[j];
            }
        }
        return ptr + 1;
    }
}