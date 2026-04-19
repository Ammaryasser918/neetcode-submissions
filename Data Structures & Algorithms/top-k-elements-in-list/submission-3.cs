public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{

    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach(int i in nums)
    {
        if (!dict.ContainsKey(i))
        {
            dict[i] = 1;
        }
        else
        {
            dict[i]++;
        }
    }

    var q = new PriorityQueue<int, int>();
    foreach(var cnt in dict)
    {
        q.Enqueue(cnt.Key, cnt.Value);
        if (q.Count > k)
        {
            q.Dequeue();
        }
    }

    List<int> ans = new List<int>();
    for(int i = 0; i < k; i++)
    {
        ans.Add(q.Dequeue());
    }

    return ans.ToArray();

}
}
