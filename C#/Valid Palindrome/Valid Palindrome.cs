public class Solution {
    public bool IsPalindrome (string s) {
        if (s == null || s.Length <= 1) return true;
        int left = -1, right = s.Length;
        bool leftFound = false, rightFound = false;
        while (left < right && left < s.Length - 1) {
            if (!leftFound) left++;
            if (ShouldSkip (s[left])) continue;
            leftFound = true;
            if (!rightFound) right--;
            if (ShouldSkip (s[right])) continue;
            rightFound = true;
            int leftASCII = ToLower ((int) s[left]), rightASCII = ToLower ((int) s[right]);
            int differASCII = leftASCII - rightASCII;
            if (differASCII < 0) differASCII = -differASCII;
            if (differASCII != 0 && differASCII != 32) return false;
            leftFound = false;
            rightFound = false;
        }
        return true;
    }
    private bool ShouldSkip (char c) {
        int index = (int) c;
        return !((index > 47 && index < 58) || (index > 64 && index < 91) || (index > 96 && index < 123));
    }
    private int ToLower (int num) {
        return num > 64 && num < 91 ? num + 32 : num;
    }
}