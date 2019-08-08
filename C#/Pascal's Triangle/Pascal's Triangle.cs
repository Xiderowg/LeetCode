public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle=new List<IList<int>>();
        if(numRows<=0) return triangle;
        IList<int> top=new List<int>();
        top.Add(1);
        triangle.Add(top);
        for(int i=1;i<numRows;i++){
            triangle.Add(Level(triangle[triangle.Count-1]));
        }
        return triangle;
    }
    
    private IList<int> Level(IList<int> upLevel){
        IList<int> level=new List<int>();
        for(int i=0;i<upLevel.Count;i++){
            int val=(i==0||i==upLevel.Count)?0:upLevel[i-1];
            level.Add(val+upLevel[i]);
        }
        level.Add(1);
        return level;
    }
}