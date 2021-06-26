using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        public static void Main()
        {
            int[] arr = Enumerable.Range(1, 10000).ToArray();
            Console.Write("Enter number you are looking for: ");
            int number = int.Parse(Console.ReadLine());
            int result = BinarySearch(arr, number);
            if (result == -1)
            {
                Console.WriteLine("The element is not presented in the given array.");
            }
            else
            {
                Console.WriteLine($"The element was found at index {result}.");
            }
        }
        static int BinarySearch(int[] arr, int element)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (arr[middle] == element)
                {
                    return middle;
                }

                if (arr[middle] < element)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
