public class Solution {
    public bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
                {
                    sb.Append(char.ToLower(c));
                }
            }

            string Pal = sb.ToString();
            int l = 0, r = Pal.Length - 1;

            while (l <= r)
            {
                if (Pal[l] != Pal[r])
                {
                    return false;
                }
                else
                {
                    l++;
                    r--;
                }
            }
            return true;


        }
}
