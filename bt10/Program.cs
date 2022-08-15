using System;
using System.Text.RegularExpressions;
namespace bt10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 5 mã sinh viên B170xxxx:");
            for(int i=1;i<=5;i++){
                string msv = Console.ReadLine();
                checkmsv(msv);
            }

        }
        static void checkmsv(string msv)
        {
            if (Regex.IsMatch(msv,"B170\\d{4}"))
                Console.WriteLine($"{msv} hợp lệ");
            else
                Console.WriteLine($"{msv}không hợp lệ");
        }
    }
}
