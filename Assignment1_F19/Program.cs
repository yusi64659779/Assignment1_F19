﻿using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();

        }
        /*
         * x – starting range, integer (int)
         * y – ending range, integer (int)
         * summary: This method prints all the self-dividing numbers between x and y. 
         * A self-dividing number is a number that is divisible by every digit it contains.
         * 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0 and 128 % 8 == 0
         * For example 1, 22 will print all the self.-dividing numbers between 1 and 22 i.e. 
         * 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22
         */
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                int[] countdown = new int[y];
                int p;
                for (int i = 0; i < y; i++)
                {
                    countdown[i] = i + 1;
                    p = countdown[i];
                    while (p > 0)
                    {
                        int d = p % 10;
                        if (d == 0 || countdown[i] % d != 0)
                            Console.WriteLine(" " + countdown[i] + " is not ");
                        p = p / 10;
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        /*
         * n – number of terms of the series, integer (int)
         * summary: This method prints the following series till n terms:
         * 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6 …. n terms
         * For example, if n = 5, output will be 1, 2, 2, 3, 3
        */
        public static void printSeries(int n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        /*
         * n – number of lines for the pattern, integer (int)
         * summary: This method prints an inverted triangle using *
         * For example n = 5 will display the output as: 
           *********
            *******
             *****
              ***
               *
        */
        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        /*
         * a – array of elements, integer (int)
         * summary: You're given an array J representing the types of stones that are 
         * jewels, and S representing the stones you have.  Each element in S is a type of 
         * stone you have.  You want to know how many of the stones you have are also jewels.
         * The elements in J are guaranteed distinct.
         * The function should return an integer.
         * For example:
         * J = [1,3], S = [1,3,3,2,2,2,2,2] will return the output: 
         * 3 (since 1, 3, 3 are jewels)
         * and
         * J = [2], S = [0,0] will return the output: 
         * 0
        */
        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        /*
         * a – array of elements, integer (int)
         * summary: This method finds the largest common contiguous subarray from two 
         * sorted arrays. The given arrays are sorted in ascending order. If there are multiple 
         * arrays with the same length, then return the last array having the maximum length.
         * The function should return the array.
         * For example:
         * a = [1,2,5,6,7,8,9], b = [1,2,3,4,5] will return the output: [1,2]
         * and
         * a = [1,2,3,4,5,6,7,8,9], b = [1,2,5,7,8,9,10] will return the output: [7,8,9]
         * and
         * a = [1,2,3,4,5,6], b = [1,2,5,6,7,8,9] will return the output: [5,6]
        */
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        /*
         * summary: At a recent college reunion meeting of one of the instructors of this 
         * class, his friend was wearing the t-shirt shown in the picture above. It was a gift
         * from his niece. Appropriate assignment of numbers to each digit solves the puzzle 
         * above. In this question, write a general method to solve puzzles such as the above.
         * The method should ask the user for the two input strings (e.g. uber, cool) and the 
         * output string (e.g. uncle) and identify a set of number assignments that solve the 
         * puzzle and print out the numbers.
        */
        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
} 


    
