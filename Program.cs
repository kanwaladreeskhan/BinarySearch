using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Binary Search ===");

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];int mid = 0;
            int low=0, high=n-1;bool found=false;
            Console.WriteLine("Enter elements in SORTED order:");
            for (int i = 0; i < n; i++)
            {
                Console.Write( "Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the number to search: ");
            int key = Convert.ToInt32(Console.ReadLine());
            while (low<=high) 
            { 
               mid=(low+high)/2;
                if (arr[mid] == key)
                {
                    Console.WriteLine("The number is at index {0}!", mid);
                    found = true;
                    break;
                }
                else if (key < arr[mid])
                {
                   high = mid - 1;
                }else if (key > arr[mid])
                {
                    low = mid+1;
                } 
            }if (!found)
            {
                Console.WriteLine("The number does not exist!");
            }
        }
    }
}
