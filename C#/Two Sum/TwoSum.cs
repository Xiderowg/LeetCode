public class Solution {
    public int[] TwoSum (int[] nums, int target) {
        int[] result = new int[2];
        int num, num2, residual;
        bool found = false;
        for (int i = 0; i < nums.Length - 1; i++) {
            num = nums[i];
            result[0] = i;
            residual = target - num;
            for (int j = i + 1; j < nums.Length; j++) {
                num2 = nums[j];
                if (num2 == residual) {
                    result[1] = j;
                    found = true;
                    break;
                }
            }
            if (found) break;
            if (i == nums.Length - 2) {
                throw new Exception ("No Solution");
            }
        }
        return result;
    }
}