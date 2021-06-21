using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[]{5,3,6,4,2,7,1};
            for(int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.WriteLine("========Start Sorting==========");
            arry.MergeSort();
            for(int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.WriteLine("Hello World! I am Done!!");
        }
    }

    public static class MergeSortEx
    {
        public static void MergeSort(this int[] array)
        {
            MergeSortHelper(array, 0, array.Length-1);
        }
        public static void MergeSortHelper(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(A, left, mid);
                MergeSortHelper(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }
        public static void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = left; x < right + 1; x++)
			{
				A[x] = B[x];
			}
        }
    }
}
