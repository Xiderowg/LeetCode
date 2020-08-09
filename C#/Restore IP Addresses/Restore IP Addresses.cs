public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        IList<string> res=new List<string>();
        IList<string> tmp=new List<string>();
        DFS(ref s,ref res,ref tmp,0);
        return res;
    }

    public void DFS(ref string s,ref IList<string> res,ref IList<string> tmp,int startIdx){
        if(tmp.Count==4){
            if(startIdx==s.Length) res.Add(string.Join('.',tmp));
            return;
        }
        string sub;
        for(int i=1;i<=3;i++){
            if(i+startIdx>s.Length) return;
            if(i>1 && s[startIdx]=='0') return;
            sub=s.Substring(startIdx,i);
            if(i==3 && int.Parse(sub)>255) return;
            tmp.Add(sub);
            DFS(ref s,ref res,ref tmp,startIdx+i);
            tmp.RemoveAt(tmp.Count-1);
        }
    }
}