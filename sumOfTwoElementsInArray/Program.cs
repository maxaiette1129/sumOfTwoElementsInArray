int[] nums = { 1, 2, 3, 4, 5, 6 };
int target = 10;

for (int j = nums.Length - 1; 0 <= j - 1; j--)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (i != j && nums[i] + nums[j] == target)
        {

            Console.WriteLine((i, j));
        }

    }
}
