using System;
using System.Linq;
namespace bt12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số phần tử của mảng nguyên dương n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arr[i]=Convert.ToInt32(Console.ReadLine());
                if(arr[i] < 0)
                {
                    Console.WriteLine("Phần tử không hợp lệ!");
                    break;
                }
            }
            
            Console.WriteLine($"Max: {arr.Max()}");
        }
    }
}
