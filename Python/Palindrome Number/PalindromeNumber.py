class Solution(object):
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """
        if(x < 0 or (x % 10 == 0 and x != 0)):
            return False

        reversed = 0
        while(reversed < x):
            reversed = reversed*10+x % 10
            x //= 10

        if(reversed == x or reversed//10 == x):
            return True
        return False
