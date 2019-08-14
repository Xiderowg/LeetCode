public class Solution {
    public int SingleNumber (int[] nums) {
        int x0 = 0, x1 = 0;
        foreach (int num in nums) {
            x1 = (x1 ^ num) & ~x0;
            x0 = (x0 ^ num) & ~x1;
        }
        return x1;
    }
}