class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        m,n=len(grid),len(grid[0])
        dp=[[0] * (n+1) for _ in range(m+1)]
        for i in range(2,m+1):
            dp[i][0]=99999999
        for j in range(2,n+1):
            dp[0][j]=99999999
        for i in range(1,m+1):
            for j in range(1,n+1):
                dp[i][j]=min(dp[i-1][j],dp[i][j-1])+grid[i-1][j-1]
        return dp[m][n]