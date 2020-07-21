class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        lo, hi = 0, len(numbers)-1
        while(numbers[lo]+numbers[hi] != target):
            if(numbers[lo]+numbers[hi] < target):
                lo += 1
            else:
                hi -= 1
        return [lo+1, hi+1]
