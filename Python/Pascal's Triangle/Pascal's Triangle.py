class Solution:
    def generate(self, numRows):
        """
        :type numRows: int
        :rtype: List[List[int]]
        """
        if(numRows<=0):
            return []
        result=[[1]]
        for i in range(numRows-1):
            result.append(self.level(result[-1]))
        return result
    
    def level(self,upLevel):
        thisLevel=[]
        newLevel=upLevel[:];
        newLevel.append(0)
        newLevel=newLevel[::-1]
        newLevel.append(0)
        for i in range(len(newLevel)-1):
            thisLevel.append(newLevel[i]+newLevel[i+1])
        return thisLevel