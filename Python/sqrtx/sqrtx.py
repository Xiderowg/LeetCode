class Solution:
    def mySqrt(self, x):
        """
        :type x: int
        :rtype: int
        """
        if (x <= 1):
            return x
        import math
        return int(math.sqrt(x))
