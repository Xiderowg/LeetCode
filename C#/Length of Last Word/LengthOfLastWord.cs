public class Solution {
    public int LengthOfLastWord (string s) {
        if (string.IsNullOrWhiteSpace (s))
            return 0;
        s = s.Trim ();
        string[] strs = System.Text.RegularExpressions.Regex.Split (s, "\\s+", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        return strs[strs.Length - 1].Length;
    }
}