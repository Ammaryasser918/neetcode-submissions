public class Solution {
    bool can(int[] piles, int h, int k)
{
    int ans = 0;
    for (int i = 0; i < piles.Length; i++)
    {
        ans += Convert.ToInt32(Math.Ceiling((double)piles[i] / k));
    }
    return ans <= h;
}

public int MinEatingSpeed(int[] piles, int h)
{
    int l = 1, r = piles.Max();
    int mid = -1, ans = -1;
    while (l <= r)
    {
        mid = l + (r - l) / 2;
        if (can(piles, h, mid))
        {
            r = mid - 1;
            ans = mid;
        }
        else
        {
            l = mid + 1;
        }
    }
    return ans;
}
}
