using System;
using System.Collections.Generic;

namespace Basic_13 {
    class Program {
        public static int greaterThanY (int[] arr, int y) {
            int count = 0;
            foreach (int num in arr) {
                if (num > y) {
                    count++;
                }
            }
            return count;
        }

        public static Array squareTheValues (int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] *= arr[i];
            }
            return arr;
        }

        public static Array eliminateNegatives (int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 0) {
                    arr[i] = 0;
                }
            }
            return arr;
        }
        static void Main (string[] args) {
            int max = 0;
            int min = 0;
            double sum1 = 0.0;
            int sum = 0;
            int count = 0;
            bool firstItem = true;
            int[] arr = { 1, 3, 5, 7, 9, 13 };
            int[] arr2 = { 1, 5, 10, 7, -2 };
            for (int i = 0; i <= 255; i++) {
                sum += i;
                // Odd Numbers
                // if (i % 2 == 1) {
                //     Console.WriteLine (i);
                // }
                // Even Numbers
                // if (i % 2 == 0) {
                //     Console.WriteLine (i);
                // }
                for (int n = 0; n <= arr.Length - 1; n++) {
                    sum1 += n;
                    count += 1;
                    if (firstItem) {
                        firstItem = false;
                        max = n;
                        min = n;
                    } else if (n > max)
                        max = n;
                    else if (n < min)
                        min = n;
                }
                // Console.WriteLine (i);
                // Console.Write ("New Number: " + i + " Sum: " + sum);
                for (int q = 0; q <= arr2.Length - 1; q++) {

                }
            }
            Console.Write ("Min = {0}; Max = {1}; Average = {2}", min, max, sum1 / count);
        }
    }
}