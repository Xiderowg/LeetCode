public class Solution {
    public int Rob (int[] nums) {
        int prev1 = 0, prev2 = 0, tmp = 0;
        foreach (var num in nums) {
            tmp = prev1;
            prev1 = Math.Max (prev1, prev2 + num);
            prev2 = tmp;
        }
        return Math.Max (prev1, prev2);
    }
}