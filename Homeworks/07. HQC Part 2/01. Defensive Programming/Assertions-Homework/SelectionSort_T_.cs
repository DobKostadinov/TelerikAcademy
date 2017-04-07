using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public class SelectionSort_T_
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                Debug.Assert(Utils.IsArrayValid(arr, 2), "Array should not be null and must have at least 2 elements in order to be sorted!");

                int minElementIndex = Utils.FindMinElementIndex(arr, index, arr.Length - 1);
                Utils.Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
    }
}
