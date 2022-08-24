using System;
using System.Linq;

namespace bt14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số phần tử của mảng n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(i=0;i<n;i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i}:");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            int j = n - 1;
            i = 0;
            while(i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.Write("\nMảng sau khi đảo ngược: ");
            for(i = 0; i < n;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
