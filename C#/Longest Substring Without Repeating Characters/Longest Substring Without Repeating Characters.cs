public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length<=1) return s.Length;
        int len=0,rs=-1;
        var hs=new HashSet<char>();
        for(int i=0;i<s.Length;i++){
            if(i!=0) hs.Remove(s[i-1]);
            if(i>=s.Length-len) break;
            while(rs+1<s.Length && !hs.Contains(s[rs+1])){
                hs.Add(s[rs+1]);
                rs++;
            }
            len=rs-i+1>len?rs-i+1:len;
        }
        return len;
    }
}