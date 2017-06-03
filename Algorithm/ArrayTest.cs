using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void SortJaggedArray()
        {
            int[][] a =
            {
                new int[] { 2,5,1,10,6,2 },
                new int[] { 10,2,8,100,1 },
                new int[] {-1,-2},
            };

            PrintJaggedArray(a);
            Console.WriteLine("xxxxxxxxxxxxxx");

            for (int i = 0; i < a.Length; i++)
            {
                Sort(a[i]);
            }
            Sort(a);

            PrintJaggedArray(a);
        }

        private void Sort(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i][0] > a[j][0])
                    {
                        Swap(a, i, j);
                    }
                }
            }
        }

        private void Swap(int[][] a, int m, int n)
        {
            int[] temp = a[m];
            a[m] = a[n];
            a[n] = temp;
        }

        public void Sort(int[] a)
        {
            for (int i=0; i<a.Length-1; i++)
            {
                for (int j=i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        Swap(a, i, j);
                    }
                }
            }
        }

        private void PrintJaggedArray(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0} ", a[i][j]);
                }
                Console.WriteLine();
            }
        }

        private void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
