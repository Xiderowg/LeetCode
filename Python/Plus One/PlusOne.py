class Solution:
    def plusOne(self, digits):
        """
        :type digits: List[int]
        :rtype: List[int]
        """
        return [int(x) for x in str(int(''.join([str(t) for t in digits]))+1)]
