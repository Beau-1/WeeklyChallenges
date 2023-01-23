using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            bool foundWord = false;

            foreach (var item in words)
            {
                if (item == null)
                {
                    return false;
                }

                if (ignoreCase == true)
                {
                    foundWord = item.ToLower() == word;
                }

                if (item == word || foundWord == true)
                {
                    return true;
                }
            }
             


            //if (ignoreCase)
            //{
            //    word = word.ToLower();
            //    words = words.Select(x => x.ToLower());
            //}

            //return words.Contains(word);

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return -1;
            }
            var charCount = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount.ContainsKey(str[i]))
                {
                    charCount[str[i]]++;
                }
                else
                {
                    charCount.Add(str[i], 1);
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }
            return Math.Max(maxCount, currentCount);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n must be greater than 0");
            }

            List<double> result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
