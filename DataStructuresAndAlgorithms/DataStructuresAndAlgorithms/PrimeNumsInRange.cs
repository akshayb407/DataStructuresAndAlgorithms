using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class PrimeNumsInRange
    {
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void FindPrimeNums()
        {

            int startingNum = 3;
            int endingNum = 14;
            for (int i = startingNum; i <= endingNum; i++)
            {
                //check if current number is prime
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}