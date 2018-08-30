class Solution:
    def maxSubArray(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        maxnum = nums[0]
        cursor = nums[0]
        for num in nums[1:]:
            cursor = num if cursor < 0 else cursor + num
            if (cursor > maxnum):
                maxnum = cursor
        return maxnum