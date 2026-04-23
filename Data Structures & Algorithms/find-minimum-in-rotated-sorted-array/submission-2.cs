public class Solution {
    public int FindMin(int[] nums)
        {
            int l = 0, r = nums.Length - 1;
            int mid = l + (r - l) / 2, ans = -1;
            while (l < r)
            {
                if (nums[r] < nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
                mid = l + (r - l) / 2;
            }

            return nums[mid];

        }
}
