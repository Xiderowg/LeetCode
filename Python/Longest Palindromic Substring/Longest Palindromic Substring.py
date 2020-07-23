class Solution:
    def longestPalindrome(self, s: str) -> str:
        if s=='':
            return ''
        n=len(s)
        ret,mx=s[0],1
        dp=[[False]*n for _ in range(n)]
        for j in range(1,n):
            for i in range(0,j):
                if j-i<3 and s[i]==s[j]:
                    dp[i][j]=True
                else:
                    dp[i][j]=dp[i+1][j-1] and (s[i]==s[j])
                if dp[i][j]:
                    m=j-i+1
                    if m>mx:
                        ret=s[i:j+1]
                        mx=m
        return ret
                    