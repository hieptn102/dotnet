using System;

namespace bt6
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sum = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 số nguyên dương:");
            int n = Convert.ToInt32(Console.ReadLine());
            if( n>0 )
            {
                for( int i = 0; i <= n; i= i + 2)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Tổng là: {sum}");
            }
            else
            {
                Console.WriteLine("Số nhập vào không hợp lệ");
            }
        }
    }
}
