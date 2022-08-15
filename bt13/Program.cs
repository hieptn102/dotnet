using System;
using System.Linq;
namespace bt13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số phần tử của mảng n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Min {arr.Min()}");
        }
    }
}
