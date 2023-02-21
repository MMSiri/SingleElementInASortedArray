internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.SingleNonDuplicate(new int[] { 1, 1, 2}));
    }
}

public class Solution
{
    public static int SingleNonDuplicate(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1]) { i++; continue; };
            return nums[i];
        }
        return nums[^1];
    }
}