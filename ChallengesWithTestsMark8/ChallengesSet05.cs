using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The input list cannot be null.");
            }

            List<double> fourthElements = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements.Add(elements[i]);
            }
            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("The input array cannot be null.");
            }

            HashSet<int> numSet = new HashSet<int>(nums);

            foreach (int num in numSet)
            {
                if (numSet.Contains(targetNumber - num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
