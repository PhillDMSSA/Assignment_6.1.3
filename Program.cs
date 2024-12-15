namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 63, 0, 3, 0, 12 };

            MoveZero(nums);

            Console.WriteLine(string.Join(",", nums));

        }
        static void MoveZero(int[] nums)
        {
            int target = 0; //pointer 

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[target]; //swap locations(index) in array
                    nums[target] = temp;
                    target++;
                }
            }

           
        }
    }
}
