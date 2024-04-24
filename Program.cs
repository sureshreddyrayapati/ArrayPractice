using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public void ArrayPrint(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Element {i+1}= {a[i]}");  
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            SumArrayEle sumArrayEle = new SumArrayEle();
            Searching searching = new Searching();
            pattren pattren=new pattren();
            //Console.WriteLine("Enter the size of array");
            //int n=Convert.ToInt32(Console.ReadLine());
            //int[] arr= new int[n];
            //for(int i=0; i<arr.Length; i++)
            //{
            //    arr[i]= Convert.ToInt32(Console.ReadLine());
            //}
            //program.ArrayPrint(arr);
            //sumArrayEle.Sum(arr);
            //sumArrayEle.LargestNumberInArray(arr);
            //sumArrayEle.SecondBigSmall(arr);
            //sumArrayEle.NthLargeNumber(arr);
            //searching.BinarySearch(arr);
            //searching.LinearSearch(arr);
            pattren.SLetter();
        }
    }
}
