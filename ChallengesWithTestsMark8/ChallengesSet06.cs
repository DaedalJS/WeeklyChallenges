using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words ==  null) { return false; }
            if (ignoreCase)
            {
                foreach (string wordsword in words)
                {
                    if (wordsword == null) { }
                    else
                    {
                        if (wordsword.ToUpper() == word.ToUpper()) { return true; }
                    }
                }
                return false;
            }
            else
            {
                return words.Contains(word);
            }
            
        }

        public bool IsPrimeNumber(int num)
        {
            
            if (num > 1) 
            {
                if (num % 2 == 0 && num != 2) { return false; }
                for (int i = 3; i < 9000; i+=2) 
                {
                    if (num % i == 0 && i != num)  { return false; }
                }
                return true;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            
            if (str.Length < 1) { return -1; }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int count = 0;
                foreach (char cha in str)
                {
                    if (cha == str[i]) { count++;}
                    if (count > 1) { break; }
                }

                if (count == 1) { return i; }
                   
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int countstored = 0;
            int stored = 0;
            foreach (int num in numbers) 
            {

                if (stored == num) 
                {
                    count++; 
                } 
                else 
                { 
                    if (count > countstored) { countstored = count; }
                    stored = num; count = 1; 
                }
                if (count > countstored) { countstored = count; }

            }
            return countstored;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < 1 || n < 1) { return new double[] { }; }
            if (n==1) { return elements.ToArray(); }
            
            List<double> NthElements = new List<double>();            
            for (int i = 0; i < elements.Count; i++)
            {
                if (((i+1) % n) == 0)
                {
                    if (i > 0)
                    {
                        NthElements.Add(elements[i]);
                    }
                }
            }

            double[] everyNthElement = NthElements.ToArray();

            return everyNthElement;
        }
    }
}
