public class Solution {
   public int MaxArea(int[] heights)
        {
            int l = 0, r = heights.Length - 1;
            int mxArea = -1;
            while (l <= r)
            {
                mxArea = Math.Max(mxArea, Math.Min(heights[l], heights[r]) * (r - l));
                if (heights[l] <= heights[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return mxArea;

        }
}
