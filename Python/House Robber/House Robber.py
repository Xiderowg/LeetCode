class Solution:
    def rob(self, nums: List[int]) -> int:
        if(len(nums) == 0):
            return 0
        prev1, prev2 = 0, 0
        for num in nums:
            tmp = prev1
            prev1 = max(prev1, prev2+num)
            prev2 = tmp
        return max(prev2, prev1)
