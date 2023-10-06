using System.Drawing;
using System;
using System.Text;
using System.Linq.Expressions;
using System.Numerics;

namespace LC_0066_PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            You are given a large integer represented as an integer array 'digits', where each 'digits[i]' is the 'ith' digit of the integer. 
            The digits are ordered from most significant to least significant in left-to-right order. The large integer does not 
            contain any leading '0''s.
            Increment the large integer by one and return the resulting array of 'digits'.
            
            Example 1:
            Input: digits = [1,2,3]
            Output: [1,2,4]
            Explanation: The array represents the integer 123.
            Incrementing by one gives 123 + 1 = 124.
            Thus, the result should be [1,2,4].
            
            Example 2:
            Input: digits = [4,3,2,1]
            Output: [4,3,2,2]
            Explanation: The array represents the integer 4321.
            Incrementing by one gives 4321 + 1 = 4322.
            Thus, the result should be [4,3,2,2].

            Example 3:
            Input: digits = [9]
            Output: [1,0]
            Explanation: The array represents the integer 9.
            Incrementing by one gives 9 + 1 = 10.
            Thus, the result should be [1,0].
             
            Constraints:
            1 <= digits.length <= 100
            0 <= digits[i] <= 9
            digits does not contain any leading 0's.
            */

            //int[] digits = new int[3] { 1, 2, 3 };
            //int[] digits = new int[4] { 4, 3, 2, 1 };
            //int[] digits = new int[1] { 9 };
            //int[] digits = new int[6] { 9, 9, 9, 9, 9, 9 };
            int[] digits = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            // Convert to int
            // add one
            // Convert back to array
            // Could do string builder with append
            // or do a way by multiplying it out based on the value
            var solutionMaybe = Solution.PlusOne(digits);

            Console.WriteLine("The answer is: ");
            for (int i= 0; i < digits.Length; i++)
            {
                Console.Write(solutionMaybe[i]);
            }
        }

        public class Solution
        {
            public static int[] PlusOne(int[] digits)
            {
                BigInteger numberValue = 0;

                for (int i = 0; i <= digits.Length-1; i++)
                {
                    numberValue = numberValue * 10;
                    numberValue = numberValue + digits[i];
                    Console.WriteLine(numberValue);
                }

                var arrayToString = numberValue.ToString();

                var stringToInteger = BigInteger.Parse(arrayToString);

                stringToInteger = stringToInteger + 1;

                var intToString = stringToInteger.ToString();

                var arrayLength = intToString.Length;

                var stringToInt = BigInteger.Parse(intToString);

                List<int> numberList = new List<int> { };

                for (int i = 0; i <= arrayLength-1; i++)
                {
                    numberList.Add(intToString[i]);
                    numberList[i] = numberList[i]-48;
                }

                int[] newArray = numberList.ToArray();

                return newArray;
            }
        }
    }
}