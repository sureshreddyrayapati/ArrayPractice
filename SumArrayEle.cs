using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SumArrayEle
    {
        public void Sum(int[] a) 
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum of array elements is "+sum);
        }
        public void LargestNumberInArray(int[] a)
        {
            int Min=int.MinValue;
            int Max=int.MaxValue;
            for(int i=0; i < a.Length; i++)
            {
                if (Min < a[i])
                {
                    Min = a[i];
                }
            }
            for(int i=0;i<a.Length; i++)
            {
                if (Max > a[i])
                {
                    Max = a[i];
                }
            }
            Console.WriteLine("Large number in ArrayList is "+Min);
            Console.WriteLine("Small number in ArrayList is " + Max);
        }
       public void SecondBigSmall(int[] a)
        {
            int Min=int.MinValue;
            int m1 = int.MinValue;
            for(int i=0; i < a.Length;i++)
            {
                if(Min < a[i])
                {
                    m1=Min;
                    Min = a[i];
                }
                else if (m1 < a[i] && Min > a[i])
                {
                    m1 = a[i];
                }
            }
            Console.WriteLine("Second Large Number in ArrayList is " +m1);
        }
        public void NthLargeNumber(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        a[i] = a[i] + a[j] - (a[j] = a[i]);
                    }
                }
            }
            for(int i=0;i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter Nth number of Large Number");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{k} Largest Number is "+a[a.Length-k]);
        }
    }
}
