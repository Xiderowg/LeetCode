class Solution:
    def titleToNumber(self, s: str) -> int:
        l, n = lambda x: ord(x)-64, len(s)
        return sum([l(s[i])*26**(n-i-1) for i in range(n)])
