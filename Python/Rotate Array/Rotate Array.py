class Solution:
    def rotate(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        n = len(nums)
        t = n-k % n
        for i in range(t):
            nums.append(nums.pop(0))
