using System;

class Program
{
    static void Main()
    {
        int[] nums1 = { 1, 3, 5, 7 };
        int[] nums2 = { 2, 4, 6, 8 };

        int[] mergedArray = MergeSortedArrays(nums1, nums2);

        Console.WriteLine("Merged Sorted Array:");
        Console.WriteLine(string.Join(", ", mergedArray));
    }

    static int[] MergeSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int[] merged = new int[m + n];

        int i = 0, j = 0, k = 0;

      
        while (i < m && j < n)
        {
            if (nums1[i] <= nums2[j])
                merged[k++] = nums1[i++];
            else
                merged[k++] = nums2[j++];
        }

      
        while (i < m)
        {
            merged[k++] = nums1[i++];
        }

      
        while (j < n)
        {
            merged[k++] = nums2[j++];
        }

        return merged;
    }
}
