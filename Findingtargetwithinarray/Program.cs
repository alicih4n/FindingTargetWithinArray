public class Program
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int x = 0; x < nums.Length; x++)
        {
            int y = x + 1;
            for (; y < nums.Length; y++)
            {

                if (nums[x] + nums[y] == target)
                {
                    result[0] = x;
                    result[1] = y;
                    return result;
                }


            }

        }

        return result;
    }

     public static void Main(string[] args)
    {
        Program p = new Program();
        int[] numbers = new int[] {1,2,3,4,5};
        int targ = 4;
        foreach(var index in p.TwoSum(numbers, targ))
        {
            Console.WriteLine(index); // It's going to be numbers of index of array.
        }
    }












}