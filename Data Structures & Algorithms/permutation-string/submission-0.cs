public class Solution {
    bool Matches(int[] s1, int[] window)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != window[i]) return false;
            }
            return true;
        }

        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;

            int[] s1cnt = new int[26];
            int[] windowcnt = new int[26];

            foreach(char c in s1)
            {
                s1cnt[c - 'a']++;
            }

            int l = 0;

            for (int i = 0; i < s2.Length; i++)
            {
                windowcnt[s2[i] - 'a']++;

                if (i - l + 1 > s1.Length)
                {
                    windowcnt[s2[l] - 'a']--;
                    l++;
                }

                if (i - l + 1 == s1.Length)
                {
                    if (Matches(s1cnt, windowcnt))
                    {
                        return true;
                    }
                }

            }
            return false;

        }
}
