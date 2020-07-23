class Solution:
    def longestPalindrome(self, s: str) -> str:
        if len(s)<=1:
            return s
        m,n=1,len(s)
        ms=s[0]
        for i in range(n):
            for w in range(m+1,n+1-i):
                if self.isPalindrome(s[i:i+w]):
                    m=w
                    ms=s[i:i+w]
        return ms
    
    def isPalindrome(self,s:str)->bool:
        left,right=0,len(s)-1
        while left<right:
            if s[left]!=s[right]:
                return False
            left+=1
            right-=1
        return True