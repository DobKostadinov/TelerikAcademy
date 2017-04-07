using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assertions_Homework
{
    public static class Utils
    {
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(IsArrayValid(arr, 2), "Array shouldn't be null and with minimun 2 elements!");
            Debug.Assert(IsSorted(arr), "Array should be sorted!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var y = list.First();
            return list.Skip(1).All(x =>
            {
                bool b = y.CompareTo(x) < 0;
                y = x;
                return b;
            });
        }

        public static bool IsArrayValid<T>(T[] arr, int numberOfElements)
        {
            if (arr == null || arr.Length < numberOfElements)
            {
                return false;
            }

            return true;
        }
    }
}
