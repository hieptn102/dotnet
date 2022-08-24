using System;
using System.Text.RegularExpressions;
namespace bt18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi");
            string sinput = Console.ReadLine();
            IsNumber(sinput);
        }
        static void IsNumber(string sinput)
        {
            if (Regex.IsMatch(sinput,"\\d"))
                Console.WriteLine("có!");
            else
                Console.WriteLine("không!");
        }
    }
}
