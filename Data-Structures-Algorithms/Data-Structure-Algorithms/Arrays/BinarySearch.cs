using System;
namespace DataStructuresAlgorithms.Arrays
{
    public class BinarySearch
    {
        public int[] arrayParam { get; set; }
        public int BinarySearchLoop(int key, int high, int lower)
        {
            while(lower <= high)
            {
                int mid = (high + lower) / 2;
                if (arrayParam[mid] == key)
                    return mid;
                if (arrayParam[mid] > key)
                    high = mid - 1;
                else
                    lower = mid + 1;
            }
            return -1;
        }

        public int BinarySearchRecursion(int key, int high, int lower)
        {
            if(lower<= high)
            {
                int mid = (high + lower) / 2;
                if (arrayParam[mid] == key)
                    return mid;
                if (arrayParam[mid] > key)
                    BinarySearchRecursion(key, mid - 1, lower);
                else
                    BinarySearchRecursion(key, high, mid + 1);
            }
            
            return -1;
        }

    }
}
