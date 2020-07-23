public class Solution {
    public int MinPathSum(int[][] grid) {
        int m=grid.Length,n=grid[0].Length;
        int[,] dp=new int[m+1,n+1];
        for(int i=2;i<=m;i++) dp[i,0]=9999999;
        for(int j=2;j<=n;j++) dp[0,j]=9999999;
        for(int i=1;i<=m;i++){
            for(int j=1;j<=n;j++){
                dp[i,j]=grid[i-1][j-1];
                dp[i,j]+=dp[i-1,j]>dp[i,j-1]?dp[i,j-1]:dp[i-1,j];
            }
        }
        return dp[m,n];
    }
}