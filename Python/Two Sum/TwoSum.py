class Solution:
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        result = []
        nums_dict = {}
        for i in range(len(nums)):
            n = nums[i]
            residual = target - n
            if (residual in nums_dict.keys()):
                if (i != nums_dict[residual]):
                    idx1 = i if i < nums_dict[residual] else nums_dict[
                        residual]
                    idx2 = i if i >= nums_dict[residual] else nums_dict[
                        residual]
                    result.append(idx1)
                    result.append(idx2)
                    break
            else:
                nums_dict[n] = i
        return result