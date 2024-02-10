using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace programs
{
    public class Class1<T> where T: IComparable<T>
    {   public void print(T[] arr)
        {
            foreach(T i in arr)
            {
                Console.Write(i+" ");
            }
        }
        public int[] bubbleSort(int[] arr)
        {
            int[] ints = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                Console.WriteLine("1");
            }
            return arr;
        }

        public T[] insertionSort(T[] arr)
        {
            print(arr);
            Console.WriteLine();
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i-1;
                T key = arr[i];

                while(j>=0 && arr[j].CompareTo(key)>0)
                {
                    arr[j + 1] = arr[j];
                    --j;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
        /*
        public T[] merge(T[] arr,int lb,int mid,int up)
        {
            T[] b = new T[up];
            int i = lb;
            int j = mid + 1;
            int k = lb;

            while(i<=mid && j <= up)
            {
                if (arr[i].CompareTo(arr[j])<0)
                {
                    b[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    b[k] = arr[j];
                    j++;
                    k++;
                }

            }
            if (i > mid)
            {
                while (j <= up)
                {
                    b[k] = arr[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i <= mid)
                {
                    b[k] = arr[i];
                    i++;
                    k++;
                }
            }
            return b;
        }*/

        public void MergeArray(T[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new T[leftArrayLength];
            var rightTempArray = new T[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i].CompareTo(rightTempArray[j])<0)
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
        public T[] mergeSort(T[] arr,int lb,int up)
        {
            if (lb < up)
            {
                int mid = (lb + up) / 2;
                mergeSort(arr, lb,mid);
                mergeSort(arr, mid + 1, up);
                MergeArray(arr,lb,mid,up);
            }
            return arr;
        }

        public int binarySearch(T[] arr, T key)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid].CompareTo(key)==0)
                {
                    return mid;
                }
                else if (arr[mid].CompareTo(key)>0)
                {
                    high = mid - 1;
                }
                else if (arr[mid].CompareTo(key)<0)
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        public bool anagram(string str1, string str2)
        {
            int count = 0;
            if (str1.Length == str2.Length)
            {
                foreach (char i in str1)
                {
                    foreach (char j in str2)
                    {
                        if (i == j)
                        {
                            count++;
                            break;
                        }
                    }
                }
                if (count == str1.Length)
                {
                    return true;
                }
            }
            return false;
        }

        public bool prime(int num)
        {
            int count = 0;
            if (num <= 1)
            {
                return false;
            }
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    public class main()
    {
        static void Main()
        {
            
            string[] arr = { "apple","donut","banana","cherry" };
            int[] arr2 = { 2, 4, 7, 9, 1 };
            Class1<string> obj = new Class1<string>();
            //obj.print(obj.bubbleSort(arr));
            //obj.print(obj.insertionSort(arr));
            /*Class1<int> obj2 = new Class1<int>();
            obj2.print(arr2);
            int[] arr3 = obj2.mergeSort(arr2, 0, arr.Length - 1);
            obj2.print(arr3);

            Class1<int> obj2 = new Class1<int>();
            Console.WriteLine("Before Merge Sort:\n");
            obj2.print(arr2);
            arr2 = obj2.mergeSort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("After Merge Sort:");
            obj2.print(arr2);


            //merge sort
            obj.print(arr);
            arr=obj.mergeSort(arr, 0, arr.Length - 1);
            obj.print(arr);  */

            Class1<int> obj2 = new Class1<int>();
            /*
            Console.WriteLine(obj2.binarySearch([10, 30, 50, 70, 80], 10));

            Console.WriteLine(obj.binarySearch(["apple", "donut", "banana", "cherry"], "donut"));

            Console.WriteLine(obj2.anagram("heart", "earth"));*/

            obj2.bubbleSort([1, 2, 3, 5, 6]);
        }
    }

}
