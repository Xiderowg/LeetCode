public class Solution {
    public int LengthOfLongestSubstring (string s) {
        int i = 0, j = 0, n = s.Length, maxLen = 0;
        HashSet<char> hSet = new HashSet<char> ();
        while (i < n && j < n) {
            if (hSet.Contains (s[j])) {
                hSet.Remove (s[i++]);
            } else {
                hSet.Add (s[j++]);
                maxLen = j - i > maxLen?j - i : maxLen;
            }
        }
        return maxLen;
    }
}