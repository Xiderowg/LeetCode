public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> result=new List<int>(){1};
        if(rowIndex==0) return result;
        int mid=rowIndex/2,i;
        for(i=1;i<=mid;i++)
            result.Add(result[i-1]/i*(rowIndex-i+1));
        if(rowIndex%2==0) i--;
        while(i>=1)
            result.Add(result[--i]);
        return result;
    }
    
}