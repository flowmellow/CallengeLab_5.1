/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one. 
Example 1: 
Input: nums = [2,2,1] 
Output: 1 
Example 2: 

Input: nums = [4,1,2,1,2] 
Output: 4 
Example 3: 

Input: nums = [1] 
Output: 1 
*/

using System;

namespace CallengeLab_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1};

            Dictionary<int, int> numberValues = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numberValues.ContainsKey(num))
                {
                    numberValues[num]++;
                   

                }

                else 
                {
                    
                    numberValues.Add(num, 1);
                    

                }

            }

            foreach (int element in numberValues.Keys)
            {
                if (numberValues[element] == 1)
                    Console.WriteLine($"Output: {element}");

                

            }




        }
    }
}
