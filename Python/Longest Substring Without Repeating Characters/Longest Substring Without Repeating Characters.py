class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hset = set()
        i = j = lng = 0
        n = len(s)
        while(i < n and j < n):
            if(s[j] in hset):
                hset.remove(s[i])
                i += 1
            else:
                hset.add(s[j])
                j += 1
                lng = max(lng, j-i)
        return lng
