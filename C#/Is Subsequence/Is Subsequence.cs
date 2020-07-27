public class Solution {
    public bool IsSubsequence(string s, string t) {
        int cur=0;
        for(int i=0;i<t.Length && cur<s.Length;i++)
            if(t[i]==s[cur]) cur++;
        return cur==s.Length;
    }
}