using System;

class Solution
{
    public static bool checkSummationOfTwoNumber(int[] nums, int target)
    {
        
        if (nums != null)
        {
            // Loop through the List
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Set Up a Second Loop that Increments the Index of the Second Number
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Store The Number
                    int d = nums[i];
                    // Next Number in Array
                    int c = nums[j];
                    // Sum the Two Numbers
                    int b = d + c;
                    // Compare with target
                    if (b == target)
                    {
                        // return value
                        return true;
                    }
                }
            }
        }
        
        // If you reached here, the sum could not be compared with your target
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



