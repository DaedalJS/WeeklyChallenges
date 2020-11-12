using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (alphabet.Contains(c) || alphabet.ToUpper().Contains(c)) { return true; } else { return false; }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Count() % 2 == 0) { return true; } else { return false; }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) { return true; } else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) { return true; } else { return false; }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
                return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null  ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum(); 
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers!= null && numbers.Sum() % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number / 2 > 0 ? number / 2 : 0;
        }
    }
}
