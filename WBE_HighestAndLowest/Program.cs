/**
 * Write a function that accepts an integer array, and returns an integer array containing only the smallest and largest numbers in the input array.
 * ie: [4,3,7,1] should return [1,7]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter numbers separated by commas\n\n>>> ");
                    string[] input = Console.ReadLine().Split(',');
                    int[] intArray = new int[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        intArray[i] = Convert.ToInt32(input[i]);
                    }
                    Console.WriteLine($"\nlowest: {FindHighestAndLowest(intArray)[0]}\nhighest: {FindHighestAndLowest(intArray)[1]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int[] FindHighestAndLowest(int[] array)
        {
            int[] output = { array[0], array[0] };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < output[0])
                {
                    output[0] = array[i];
                }
                else if (array[i] > output[1])
                {
                    output[1] = array[i];
                }
            }
            return output;
        }
    }
}
