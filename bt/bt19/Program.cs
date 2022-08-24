using System;

namespace bt19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi");
            string sinput = Console.ReadLine();
            int sum = 0;
            Console.Write("Vị trí xuất hiện");
            for (int i = 0; i < sinput.Length; i++) {
                if (sinput[i] == 'a') {
                    sum ++;
                    Console.Write($" {i}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Số lần xuất hiện của a trong chuỗi là:{sum}");
        }
    }
}
