public class Solution {
    public int MaxProfit(int[] prices)
        {
            int l = 0, r = 0;
            int ans = 0;
            while (r < prices.Length - 1)
            {
                if (prices[l] > prices[r])
                {
                    l = r;
                }
                r++;
                ans = Math.Max(ans, prices[r] - prices[l]);
            }
            return ans;
        }
}
