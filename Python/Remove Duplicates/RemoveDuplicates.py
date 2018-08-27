class Solution:
    def removeDuplicates(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        if(len(nums) <= 1):
            return len(nums)
        ptr = 0
        for i in range(1, len(nums)):
            if(nums[ptr] != nums[i]):
                ptr += 1
                nums[ptr] = nums[i]
        return ptr+1
