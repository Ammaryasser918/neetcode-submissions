public class Solution {
    public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;

            while (l < r)
            {
                if (numbers[l] + numbers[r] > target)
                {
                    r--;
                }
                else if (numbers[l] + numbers[r] < target)
                {
                    l++;
                }
                else
                {
                    return new List<int>() { l + 1, r + 1}.ToArray();
                }
            }
            return new List<int>().ToArray();

        }
}
