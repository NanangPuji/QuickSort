﻿using System.Xml;

namespace Quicksort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;// number of comparasion
        private int mov_count = 0;// number of data movements

        //number of element in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray acn have maximum 20 elements \n");
            }
            Console.WriteLine("\n=====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=====================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low,int high)
        {

        }
