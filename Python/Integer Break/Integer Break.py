class Solution:
    def integerBreak(self, n: int) -> int:
        dp=[0]*59
        for i in range(2,59):
            for j in range(1,i):
                dp[i]=max(dp[i],j*dp[i-j],j*(i-j))
        return dp[n]
