using System;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Rotate(nums, k);

        Console.WriteLine("Array after rotation:");
        Console.WriteLine(string.Join(", ", nums));
    }

    static void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n; 

      
        Reverse(nums, 0, n - 1);

        Reverse(nums, 0, k - 1);

       
        Reverse(nums, k, n - 1);
    }

    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }
}
