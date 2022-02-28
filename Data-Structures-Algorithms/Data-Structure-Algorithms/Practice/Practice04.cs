using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    /// <summary>
    /// Carry Forward
    /// </summary>
    public class Practice04
    {
        /*
         You have given a string A having Uppercase English letters.

         You have to find that how many times subsequence "AG" is there in the given string.

         NOTE: Return the answer modulo 109 + 7 as the answer can be very large.
         */

        public int CountGivenCombination(string A)
        {
            int count = 0, gTracker =0;

            for (int i = A.Length -1; i >= 0; i--)
            {
                if (A[i] == 'G') gTracker++;
                if (A[i] == 'A') count += gTracker;
            }

            return count;
        }

        /*
         Given an array A. Find the size of the smallest subarray such that
         it contains atleast one occurrence of the maximum value of the array
         and atleast one occurrence of the minimum value of the array.
         */

        public int SmallestSubArray(List<int> A)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int iMin = -1, iMax = -1;
            int ansL = A.Count;

            //[1, 3, 9 2 4 5 9 7 2 1]

            for(int i = 0; i< A.Count; i++)
            {
                max = Math.Max(max, A[i]);
                min = Math.Min(min, A[i]);
            }
            if (max == min) return 1;

            for (int i = 0;i < A.Count; i++)
            {
                if (A[i] == max)
                {
                    iMax = i;
                    if (iMin != -1) {
                        ansL = Math.Min(ansL, Math.Abs(iMax - iMin) + 1);
                    }
                }
                else if (A[i] == min)
                {
                    iMin = i;
                    if (iMax != -1)
                    {
                        ansL = Math.Min(ansL, Math.Abs(iMax - iMin) + 1);
                    }
                }
            }

            return ansL;
        }

        /*
        N light bulbs are connected by a wire.
        Each bulb has a switch associated with it, however due to faulty wiring,
        a switch also changes the state of all the bulbs to the right of current bulb.
        Given an initial state of all bulbs, find the minimum number of switches you have
        to press to turn on all the bulbs.
        You can press the same switch multiple times.
        Note: 0 represents the bulb is off and 1 represents the bulb is on.
        [0, 1, 0, 1]
         */

        public int SwitchOnBulbs(List<int> A)
        {
            int count = 0;
            if (A.Count == 0) return 0;

            int current = A[0];
            int previous = A[0];

            if (current == 0) count++;
            for (int i = 1; i < A.Count; i++)
            {
                current = A[i];
                if (current != previous)
                {
                    previous = current;
                    count++;
                }
            }
            return count;
        }

        /*
        Given an integer array A containing N distinct integers, you have to find all the leaders in the array A.
        An element is leader if it is strictly greater than all the elements to its right side.
        NOTE:The rightmost element is always a leader.
         */

        public List<int> FindLeaders(List<int> A)
        {
            var leaders = new List<int>();
            var totalParticipant = A.Count;
            int lastMax = A[totalParticipant - 1];
            leaders.Add(lastMax);

            //[16, 17, 4, 3, 5, 2]
            for (int i = totalParticipant - 2; i >= 0; i--)
            {
                int current = A[i];
                if (current > lastMax)
                {
                    lastMax = current;
                    leaders.Add(current);
                }
            }

            return leaders;
        }

        /*
        You are given a string S, and you have to find all the amazing substrings of S.
        Amazing Substring is one that starts with a vowel (a, e, i, o, u, A, E, I, O, U).
        Input
         */

        public int FindAmazingSubarrays(string A)
        {
            int count = 0;
            int totalSubArray = 0;
            //"ABEC"
            for (int i = A.Length - 1; i >= 0; i--)
            {
                char current = A[i];
                count++;
                if (IsVowel(current))
                {
                    totalSubArray += count;
                }
            }
            return totalSubArray % 10003;
        }
        private bool IsVowel(char c)
        {
                return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
        }


        /*
        Problem Description
        You are given an integer array A.
        Decide whether it is possible to divide the array into one or
        more subarrays of even length such that first and last element of all subarrays will be even.
        Return "YES" if it is possible otherwise return "NO" (without quotes).
         */
        public string FindEvenSubArrays(List<int> A)
        {
            if (A.Count % 2 != 0 || A[0] % 2 != 0 || A[A.Count - 1] % 2 != 0)
                return "NO";
            else
                return "YES";
        }
    }
}
