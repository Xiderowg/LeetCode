class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        n = len(nums)
        if(n <= 1):
            return False
        num_dict = {}
        for i in range(n):
            if(nums[i] in num_dict.keys() and i-num_dict[nums[i]] <= k):
                return True
            num_dict[nums[i]] = i
        return False
