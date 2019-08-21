class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        max_count=len(nums)/2
        num_dict={}
        for num in nums:
            if num in num_dict.keys():
                num_dict[num]+=1
            else:
                num_dict[num]=1
            if(num_dict[num]>max_count):
                    return num
        return -1