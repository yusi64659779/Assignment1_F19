using System;

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
            for (int r = 0; r < r5.Length; r++)
                Console.Write(r5[r] + " ");

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
        //self-reflection: At first, I did not realize the multiple of 10.
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                //rem will be used to store every digit in a number
                int rem = 0;
                //Iterate through the numbers between x and y
                for (int i = x; i <= y; i++)
                {
                    //num will be used to input the self-dividing numbers
                    int num = i;
                    //div will be used to get every digit a number
                    int div = i;
                    //Print all the self.-dividing numbers using While loop
                    while (div != 0)
                    {
                        //After dividing by 10, get every digit by taking the remainder, for example: 128%10->8
                        rem = div % 10;
                        //Remove the  multiple of 10
                        if (rem == 0)
                            break;
                        //Remove the number that cannot be divisible by digit it contains
                        if (num % rem != 0)
                            break;
                        //For example: 128/10->12; 12->1
                        div = div / 10;
                        //Input the self-dividing numbers
                        if (div == 0)
                            Console.Write(" " + num);
                    }
                    
                }
                Console.WriteLine();
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
        //self-reflection: the key of this question is to set a counter to control the numbers that will be output
        public static void printSeries(int n)
        {
            //t will be used to control how many numbers will be output
            int t = 0;
            try
            {
                //Output the number from 1 to n
                for (int i = 1; i <= n; i++)
                {
                    //Iterate the number
                    for (int j = 0; j < i; j++)
                    {
                        //Control how many numbers will be output using if clause
                        if (t < n)
                        {
                            Console.Write(" " + i);
                            //When a number is output, t plus 1 until t=n, the loop ends
                            t++;
                        }
                    }
                }
                Console.WriteLine();
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
        //self-reflection:this fomula-2 * (n - k) + 1 is the key in my codes
        public static void printTriangle(int n)
        {
            try
            {
                //Iterate through 5 rows using for loop
                for (int k = 1; k <= n; k++)
                {
                    //Iterate through the space of "*" using for loop
                    for (int i = 1; i < k; i++)
                        Console.Write(" ");
                    //Iterate through the "*" in each row using for loop
                    for (int j = 1; j <= 2 * (n - k) + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
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
        //self-reflection:I think it's relatively easy for me.
        public static int numJewelsInStones(int[] J, int[] S)
        {
            //sum will be used to record how many numbers in S that are also in J
            int sum = 0;
            try
            {
                //Iterate through the S array using for loop
                for (int i = 0; i < S.Length; i++)
                {
                    //Iterate through the J array using for loop
                    for (int t = 0; t < J.Length; t++)
                    {
                        //Determine whether the number in S is equal to the number in J
                        if (S[i] == J[t])
                            sum = sum + 1;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return sum;
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
        //self-reflection:I think tracking the position of the contiguous equal numbers and getting the length of required array were hard for me.
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            //This variable is uesd to iterate through the array a
            int i;
            //This variable is used to get the value from "count" 
            int len = 0;
            //This variable is the position of the last equal number in the last array having the maximum length 
            int last = 0;
            //This variable is used to iterate through the array b
            int j = 0;
            //This variable is used to calculate how many equal numbers are contiguous 
            int count = 0;          
            try
            {
                ////Iterate through the a array using for loop
                for (i = 0; i < a.Length; i++)
                {
                    //Iterate through the b array using for loop
                    for (; j < b.Length; j++)
                    {
                        if (b[j] == a[i])
                        {
                            //Calculate how many contiguous equal elements in these two arrays
                            count++;
                            //Swap the b array to the same position as a array
                            j++;
                            break;
                        }
                        //If the numbers in a and be are not equal, How many contiguous equal numbers have been counted before and the last position of contiguous equal numbers need to be recorded 
                        else
                        {
                            //Compare so that we can get the max length of contiguous commomn array
                            if (count >= len)
                            {
                                len = count;
                                count = 0;
                                last = i - 1;
                            }
                            //As the array is sorted we can compare and lements are not equal , we can compare the next element
                            if (a[i] < b[j])
                            {
                                count = 0;
                                break;
                            }

                        }

                    }
                }
                //Get count, len and end last value outside the loop
                if (count >= len)
                {
                    len = count;
                    count = 0;
                    last = i - 1;
                }
                //Output the last array having the maximum length
                int[] c = new int[len]; j = 0;
                for (i = last - len + 1; i <= last; i++, j++)
                {
                    c[j] = a[i];
                }
                return c; // return the actual array
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null;
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
            //logic: 1.find all of the common letters in the two strings
            //       2.split the uncommon letters in the two strings
            //       3.find how many letters between these uncommon letters, and get the number
            //       4.find the letter in step 3
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


    

