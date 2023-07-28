using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConaAppLinsearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConAppLinearsearch


    {

        internal class Program
        {
            public static int BinarySearch(int[] arr, int sItem)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (arr[mid] == sItem)
                    {
                        return mid;
                    }
                    else if (arr[mid] < sItem)
                    {
                        left = mid + 1;


                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return -1;

            }
            

            private static void Main(string[] args)
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine("enter search item to search by using binary");
                int sItem = int.Parse(Console.ReadLine());
                int result = BinarySearch(arr, sItem);
                if (result != -1)
                {
                    Console.WriteLine($"{sItem} Found at index {result}");
                }
                else
                {
                    Console.WriteLine(
                    "no such item found");
                }
                
            }
        }



    }
}