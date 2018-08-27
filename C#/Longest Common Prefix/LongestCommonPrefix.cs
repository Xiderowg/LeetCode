public class Solution {
    public string LongestCommonPrefix (string[] strs) {
        if (strs.Length == 0 || strs == null) return "";
        string str = strs[0];
        for (int i = 0; i < strs[0].Length; i++) {
            char s = str[i];
            for (int j = 1; j < strs.Length; j++) {
                if (i == strs[j].Length || strs[j][i] != s) {
                    return str.Substring (0, i);
                }
            }
        }
        return str;
    }
}