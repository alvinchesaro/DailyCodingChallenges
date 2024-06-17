using System;

class Solution
{
    public static bool checkSummationOfTwoNumber(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int d = nums[i];
                int c = nums[j];
                int b = d + c;
                if (b == target)
                {
                    return true;
                }
            }
        }

        return false;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = [10, 3, 12, 7];
            int comparo = 17;
            
            bool result = Solution.checkSummationOfTwoNumber(numeros, comparo);

            Console.WriteLine(result);
        }
    }

}



