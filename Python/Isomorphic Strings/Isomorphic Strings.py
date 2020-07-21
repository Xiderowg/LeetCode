class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        hmap = {}
        for i in range(len(s)):
            if(s[i] in hmap.keys()):
                if(hmap[s[i]] != t[i]):
                    return False
            else:
                if(t[i] in hmap.values()):
                    return False
                hmap[s[i]] = t[i]
        return True
