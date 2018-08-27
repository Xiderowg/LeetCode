class Solution:
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        stack = []
        oppo = (')', ']', '}')
        if(len(s) % 2 != 0):
            return False
        for c in s:
            pos = '([{'.find(c)
            if(pos >= 0):
                stack.append(oppo[pos])
            elif(stack==[] or stack.pop() != c):
                return False
        return stack == []