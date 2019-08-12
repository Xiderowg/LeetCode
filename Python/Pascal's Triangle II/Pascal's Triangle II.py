class Solution:
    def getRow(self, rowIndex):
        """
        :type rowIndex: int
        :rtype: List[int]
        """

        def c(n, r): return self.fact(n)//(self.fact(r)*self.fact(n-r))
        return [c(rowIndex, r) for r in range(rowIndex+1)]

    def fact(self, n):
        if(n <= 1):
            return 1
        return self.fact(n-1)*n
