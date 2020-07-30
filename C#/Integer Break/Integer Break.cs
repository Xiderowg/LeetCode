public class Solution {
    public int IntegerBreak(int n) {
        int[] dp=new int[n+1];
        for(int i=2;i<=n;i++){
            int curMax=0;
            for(int j=1;j<i;j++){
                curMax=Math.Max(dp[i-j]*j,(i-j)*j);
                if(dp[i]<curMax) dp[i]=curMax;
            }
        }
        return dp[n];
    }
}