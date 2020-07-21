class Solution:
    def isPalindrome(self, s: str) -> bool:
        cs = ''.join(c.lower() if c.isalnum() else '' for c in s)
        return cs == cs[::-1]
