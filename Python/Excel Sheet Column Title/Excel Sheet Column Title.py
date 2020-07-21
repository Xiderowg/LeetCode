class Solution:
    def convertToTitle(self, n: int) -> str:
        s = ''
        while(n > 0):
            res = n % 26
            n = int((n-res)/26)
            if(n != 0 and res == 0):
                n -= 1
                res = 26
            if(res != 0):
                s += chr(res+64)
            if(n > 0 and n <= 26):
                s += chr(n+64)
                n = 0
        return s[::-1]
