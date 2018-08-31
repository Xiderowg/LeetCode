public class Solution {
    public int ClimbStairs (int n) {
        if (n <= 1) return 1;
        dp = new int[n];
        dp[0] = 1;
        dp[1] = 2;
        return ClimbStairsHelper (n, ref dp);
    }

    private int[] dp;

    private int ClimbStairsHelper (int n, ref int[] dp) {
        if (dp[n - 1] == 0) {
            dp[n - 1] = ClimbStairsHelper (n - 2, ref dp) + ClimbStairsHelper (n - 3, ref dp);
        }
        return dp[n - 1];
    }
}