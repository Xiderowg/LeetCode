class Solution:
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        isNegative=True if x<0 else False
        strX=str(-x) if isNegative else str(x)
        prefix="-" if isNegative else ""
        result=prefix+strX[::-1]
        result=int(result)
        if(result<-2147483648 or result>2147483647):
            result=0
        return result