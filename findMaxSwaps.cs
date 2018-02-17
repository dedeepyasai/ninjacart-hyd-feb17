using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class findMaxSwaps
    {
        public static void swap_function(ref int a, ref int b) {
            int tempswap = a;
            a = b;
            b = tempswap;
        }
        public static void kswap_function(int[] arr) {
            int k = 0;
            int k_max = 0;
            int n = arr.Length;
            int max = Arrayinput(arr);
            for (int i = 0; i < n - 1; i++)
            {    swap_function(ref arr[i],ref arr[i+1]);
                    k++;
                if (max < Arrayinput(arr)) {
                    max = Arrayinput(arr);
                     k_max=k;
                }
            }
            Console.Write("{0} {1}",max,k_max);
        }
        public static int[] inputArray(int i) {
            List<int> result = new List<int>();
            while (i != 0)
            {
                result.Insert(0,i % 10);
                i /= 10;
            }
            return result.ToArray();
        }
         public static int Arrayinput(int[] array) {
             int result = 0;
         int multipicator = 1;
         for (int i = array.Length - 1; i >= 0; i--)
         {
            result += array[i] * multipicator;
            multipicator *= 10;
         }
            return result;
         }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = inputArray(input);
           /* foreach (int i in arr) {
         //       Console.WriteLine(i);
            }*/
            kswap_function(arr);
            Console.ReadKey();
        }
    }
}
