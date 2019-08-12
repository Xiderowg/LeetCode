public class Solution {
    public int MaxProfit(int[] prices) {
        List<int> profits=new List<int>();
        int buyPrice,sellPrice;
        for(int i=0;i<prices.Length;i++){
            buyPrice=prices[i];
            sellPrice=buyPrice;
            for(int j=i;j<prices.Length;j++){
                sellPrice=prices[j]>sellPrice?prices[j]:sellPrice;
            }
            profits.Add(sellPrice-buyPrice);
        }
        return profits.Count>0?profits.Max():0;
    }
}