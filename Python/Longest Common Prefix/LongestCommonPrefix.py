class Solution:
    def longestCommonPrefix(self, strs):
        """
        :type strs: List[str]
        :rtype: str
        """
        if(len(strs)==0):
            return ""
        str0 = strs[0]
        for i in range(len(str0)):
            s0 = str0[i]
            for j in range(1, len(strs)):
                if(i == len(strs[j]) or strs[j][i] != s0):
                    return str0[:i]
        return str0
