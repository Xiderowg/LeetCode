public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length<=1) return s;
        string ret=s.Substring(0,1);
        int mx=1;
        bool[,] dp=new bool[s.Length,s.Length];
        for(int i=1;i<s.Length;i++){
            for(int j=0;j<i;j++){
                if(i-j<3 && s[i]==s[j])
                    dp[i,j]=true;
                else
                    dp[i,j]=dp[i-1,j+1] && (s[i]==s[j]);
                if(dp[i,j]){
                    int m=i-j+1;
                    if(m>mx){
                        mx=m;
                        ret=s.Substring(j,i-j+1);
                    }
                }
            }
        }
        return ret;
    }
}