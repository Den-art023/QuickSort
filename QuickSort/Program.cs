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
        }
        static void Main(string[] args)
        {
        }
    }
}
