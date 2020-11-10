using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            if (n <= 0)
            {
                return new List<int>();
            }
            List<int> res = new List<int>();
            foreach(int i in GetNaturalNumbers(n - 1))
            {
                res.Add(i);
            }
            res.Add(n);
            return res;
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumNaturalNumbers(n-1);
        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, 2);
        }

        private bool IsPrime(int n, int current)
        {
            // Base cases 
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % current == 0)
                return false;
            if (current * current > n)
                return true;

            // Check for next divisor 
            return IsPrime(n, current + 1);
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
            //return text.SequenceEqual(text.Reverse());
        }
    }
}
