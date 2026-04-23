public class Solution {
    public int CharacterReplacement(string s, int k)
        {
            int l = 0, r = 0;
            int MaxFreq = 0;
            int res = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            while (r < s.Length)
            {
                if (!dict.ContainsKey(s[r]))
                {
                    dict[s[r]] = 0;
                }

                dict[s[r]]++;
                MaxFreq = Math.Max(MaxFreq, dict[s[r]]);

                while((r - l + 1) - MaxFreq > k)
                {
                    dict[s[l]]--;
                    l++;
                }
                res = Math.Max(res, r - l + 1);
                r++;
            }
            return res;
        }
}
