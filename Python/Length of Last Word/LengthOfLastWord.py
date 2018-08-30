class Solution:
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        if (s.strip() == ''):
            return 0
        return len(s.split()[-1])