using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //Array of integers to holf values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparison
        private int mov_count = 0; //Number of data movements

        //Number of element in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can make maximum 20 elements\n");
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("Enter array elements");
            Console.WriteLine("\n==================");

            //Get array element
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //Swaps the elements at index x with element at index y
        void  swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_short(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
            i = low + 1;
            j = high;

            pivot = arr[low];

            while(i <= j)
            {
                //Search for an element greater that pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equal to pivot
                while((arr[j] > pivot) && (j >= high))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //If the greater element is on the left of the element
                {
                    //Swap the element at idex i with the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if(low < j)
            {
                //Move the pivot to its corect position in the list
                swap(low, j);
                mov_count++;
            }
            //sort the list  on the left of pivot using quick sort
            q_short(low, j - 1);

            //Sort the list on the right of pivot using quick sort
            q_short(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("\n---------------------");

            for(int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movement: " + mov_count);
        }
        static void Main(string[] args)
        {
        }
    }
}
