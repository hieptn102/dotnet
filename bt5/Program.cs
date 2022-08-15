using System;
using System.Text.RegularExpressions;
namespace bt5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào MSSV: ");
            string sinput = Console.ReadLine();
            if (Regex.IsMatch(sinput,"B\\d{7}"))
                Console.WriteLine("MSV hợp lệ");
            else
                Console.WriteLine("MSV không hợp lệ");
         }
    }
}
