class Solution:
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        if (n <= 1):
            return 1
        dp = [0 for x in range(n)]
        dp[0] = 1
        dp[1] = 2
        return self.climbStairsHelper(n - 1, dp)

    def climbStairsHelper(self, n, dp):
        """
        :type n: int
        :type dp: list
        :rtype: int
        """
        if (dp[n] == 0):
            dp[n] = self.climbStairsHelper(n - 1, dp) + self.climbStairsHelper(
                n - 2, dp)
        return dp[n]
