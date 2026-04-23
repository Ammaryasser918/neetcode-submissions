public class Solution {
    public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int l = 0, r = 0;
            int ans = 0;
            while (r < s.Length)
            {
                if (!dict.ContainsKey(s[r]))
                {
                    dict[s[r]] = 0;
                }

                if (dict[s[r]] == 0)
                {
                    dict[s[r]]++;
                    r++;
                }
                else
                {
                    dict[s[l]]--;
                    l++;
                }
                ans = Math.Max(ans, r - l);
            }
            return ans;
        }
}
