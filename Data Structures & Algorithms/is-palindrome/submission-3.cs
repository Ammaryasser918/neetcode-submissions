public class Solution {
    public bool IsPalindrome(string s)
        {
            string Pal = "";
            foreach(char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    Pal += char.ToLower(c);
                }
            }

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
