class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        l,rs,n=0,-1,len(s)
        hs=set()
        for i in range(n):
            if i!=0:
                hs.remove(s[i-1])
            while rs+1<n and s[rs+1] not in hs:
                hs.add(s[rs+1])
                rs+=1
            l=max(l,rs-i+1)
        return l