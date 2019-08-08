class Solution:
    def maxProfit(self, prices):
        """
        :type prices: List[int]
        :rtype: int
        """
        if(not prices):
            return 0
        buyPrice,profit=prices[0],0
        for i in range(1,len(prices)):
            price=prices[i]
            if(price<buyPrice):
                buyPrice=price
                continue
            if(price-buyPrice>profit):
                profit=price-buyPrice
        return profit
        