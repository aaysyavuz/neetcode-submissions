public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0, sell = 1, result = 0;

        while (buy < sell && sell < prices.Length) {
            if (prices[buy] > prices[sell]) {
                buy = sell;
            } else {
                result = Math.Max(result, prices[sell] - prices[buy]);
            }
            sell++;
        }

        return result;
    }
}
