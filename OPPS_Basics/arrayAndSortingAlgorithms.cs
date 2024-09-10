namespace Arrays
{
    public class ArrayExample
    {   //Array Example
        public void ArrayExampleMethod(int size)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //Binary Search Method
        public void BinarySearch(int[] numbers, int key)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                //to avoid overflow else can also use mid = (low + high) / 2;
                mid = (low + high - low) / 2;
                if (numbers[mid] == key)
                {
                    Console.WriteLine("Element Found");
                    break;
                }
                else if (numbers[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        //Merge Two Arrays as well Sorting is done
        public void MergeArrays(int[] arr1, int[] arr2)
        {

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3[k++] = arr1[i++];
                }
                else
                {
                    arr3[k++] = arr2[j++];
                }
            }

            while (i < arr1.Length)
            {
                arr3[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                arr3[k++] = arr2[j++];
            }

            for (int l = 0; l < arr3.Length; l++)
            {
                Console.Write(arr3[l] + " ");
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());
            ArrayExample arr = new ArrayExample();
            arr.ArrayExampleMethod(size);

            //bubble sort
            arr.BubbleSort(numbers);

            //Binary Search
            int key = int.Parse(Console.ReadLine());
            arr.BinarySearch(numbers, key);

            //Merge two arrays
            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            arr.MergeArrays(arr1, arr2);

            //Merge Sort
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            MergeSort mergeSort = new MergeSort();
            mergeSort.MergeSortMethod(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }

}


//Sorting algorithm 
namespace SortingAlgorithms
{
    public class SortingAlgorithms
    {
        //Bubble Sort Algorithm
        public void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length -i- 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
        }

        //Selection Sort Algorithm
        public void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);

            }
        }


        //Insertion Sort Algorithm
        public void InsertionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
        }
    }
    
    //Merge Sort Algorithm (Recursion)
    public class MergeSort
    {
        public void MergeSortMethod(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = (start + end) / 2;
            MergeSortMethod(arr, start, mid);
            MergeSortMethod(arr, mid + 1, end);
            Merge(arr, start, end);

        }

        public void Merge(int[] arr, int start, int end)
        {
            int mid = (start + end) / 2;
            int len1 = mid - start + 1;
            int len2 = end - mid;

            int[] left = new int[len1];
            int[] right = new int[len2];

            int mainArrayIndex = start;
            for (int i = 0; i < len1; i++)
            {
                left[i] = arr[mainArrayIndex++];

            }

            mainArrayIndex = mid + 1;
            for (int i = 0; i < len2; i++)
            {
                right[i] = arr[mainArrayIndex++];
            }

            int index1 = 0, index2 = 0;
            mainArrayIndex = start;
            while (index1 < len1 && index2 < len2)
            {
                if (left[index1] < right[index2])
                {
                    arr[mainArrayIndex++] = left[index1++];
                }
                else
                {
                    arr[mainArrayIndex++] = right[index2++];
                }
            }

            while (index1 < len1)
            {
                arr[mainArrayIndex++] = left[index1++];
            }
            while (index2 < len2)
            {
                arr[mainArrayIndex++] = right[index2++];
            }

        }

    }

    //Quick Sort Algorithm (Recursion)
    public class QuickSortAlgorithm
    {
        public void QuicSort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int pi = Partition(arr, low, high);
            QuicSort(arr, low, pi - 1);
            QuicSort(arr, pi + 1, high);
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int count = 0;
            for (int k = low + 1; k <= high; k++)
            {
                if (arr[k] < pivot)
                {
                    count++;
                }
            }
            int pivotIndex = low + count;
            (arr[low], arr[pivotIndex]) = (arr[pivotIndex], arr[low]);


            int i = low, j = high;
            while (i < pivotIndex && j > pivotIndex)
            {
                if (arr[i] < pivot)
                {
                    i++;
                }
                else if (arr[j] >= pivot)
                {
                    j--;
                }
                else
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++;
                    j--;
                }

            }
            return pivotIndex;

        }
    }
    class Program
    {
        static void Main()
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            //Uncomment the sorting algorithm you want to use

            SortingAlgorithms sorting = new SortingAlgorithms();
            sorting.BubbleSort(numbers);
            //sorting.SelectionSort(numbers);
            //sorting.InsertionSort(numbers);
            //MergeSort mergeSort = new MergeSort();
            //mergeSort.MergeSortMethod(numbers, 0, numbers.Length - 1);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            //Quick Sort
            int[] ints = { 24, 12, 8, 45, 1, 2, 3, 8, 4, 56, 7, 8, 9, 10 };
            QuickSortAlgorithm quickSort = new QuickSortAlgorithm();
            quickSort.QuicSort(ints, 0, ints.Length - 1);
            foreach (var number in ints)
            {
                Console.Write(number + " ");
            }

        }
    }
}



//Logic for removing duplicates from an array
using System;
class RemoveDuplicate
{
    public static int[] RemoveDuplicates(int[] arr)
    {
        int n = arr.Length;
        int[] temp = new int[n];
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;
            for (int k = 0; k < j; k++)
            {
                if (arr[i] == temp[k])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                temp[j++] = arr[i];
            }
        }

        int[] result = new int[j];
        for (int i = 0; i < j; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }
    public static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
        int n = arr.Length;
        int[] result = RemoveDuplicates(arr);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}


//Dutch National Flag Algorithm
//Only for sorting 0,1,2 in an array
//Time Complexity : O(n) and Space Conplexity : O(1)


namespace DutchNationFlag
{
    class Sorting
    {
        public void SortColors(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;
            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    Swap(arr, low, mid);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    Swap(arr, mid, high);
                    high--;
                }
            }
        }
        void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    class Program
    {
        static void Main()
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            Sorting sort = new Sorting();   
            sort.SortColors(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
