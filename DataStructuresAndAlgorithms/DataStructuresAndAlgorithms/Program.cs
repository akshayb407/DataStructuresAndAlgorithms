using System;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======String Permutations======");
            string str = "kgf";
            StringPermutations.Permute(str, 0, str.Length - 1);
            Console.WriteLine("======Searching String======");
            WordsList.SearchString();

            Console.WriteLine("=======Sorted List========");
            string[] names = { "Ramesh", "Suresh", "Mahesh", "Ilesh" };
            WordsList.InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======Sorted List Using Bubble Sort=======");
            WordsList.BubbleSort();
            Console.WriteLine();

            Console.WriteLine("=======List prior to Merge Sorting=======");
            int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            MergeSorting.MergeSort(arr, 0, n - 1);
            Console.WriteLine();
            Console.WriteLine("=======Sorted List Using Merge Sorting=======");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=======Finding word if it is Anagram=======");
            Anagram.FindAnagram();

            Console.WriteLine("========Finding Prime Nums in given range===============");
            PrimeNumsInRange.FindPrimeNums();
        }
    }
}
    
