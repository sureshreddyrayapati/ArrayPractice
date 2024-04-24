using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Searching
    {
        public void BinarySearch(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] + arr[j] - (arr[j] = arr[i]);
                    }
                }
            }
            Console.WriteLine("Enter search element");
            int key = Convert.ToInt32(Console.ReadLine());
            bool b = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left <= right)
                {
                    int mid=(left + right)/2;
                    if (arr[i] == key)
                    {
                        b=true;
                        break;
                    }
                    else if (arr[i]< key)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right=mid - 1;
                    }
                }

            }
            if( b )
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void LinearSearch(int[] arr)
        {
            Console.WriteLine("Enter Searching element");
            int key= Convert.ToInt32(Console.ReadLine());
            bool b = false;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    b=true;
                    break;
                }
            }
            if(b)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
