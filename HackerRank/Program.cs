using System;
using System.Text;

namespace HackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            StringBuilder sb = new StringBuilder();

            for(int i = arr.Length -1; i >= 0; i--)
            {
                sb.Append(arr[i] + " ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}