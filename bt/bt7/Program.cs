using System;

namespace bt7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
            for( int i = 1; i <= 20; i++)
            {
                sum =i*n;
                Console.WriteLine($"{i}X{n} = {sum}");
            }
            
        }
    }
}
