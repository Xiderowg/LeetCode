class Solution:
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        num_dict = {"I": 1, "V": 5, "X": 10,
                    "L": 50, "C": 100, "D": 500, "M": 1000}
        result = 0
        for i in range(len(s)-1):
            c = s[i]
            cn = s[i+1]
            if(self.superior(cn, c)):
                result -= num_dict[c]
            else:
                result += num_dict[c]
        result += num_dict[s[len(s)-1]]
        return result

    def superior(self, s1, s2):
        """
        :type s1: str
        :type s2: str
        :rtype: bool
        """
        if(s1 == "I"):
            return False
        elif(s1 == "V" or s1 == "X"):
            if(s2 == "I"):
                return True
            else:
                return False
        elif(s1 == "L" or s1 == "C"):
            if(s2 == "X"):
                return True
            else:
                return False
        elif(s1 == "D" or s1 == "M"):
            if(s2 == "C"):
                return True
            else:
                return False
