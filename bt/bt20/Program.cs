using System;
using System.Text.RegularExpressions;
namespace bt20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi có độ dài không quá 20 kí tự không được chứa ký tự khoảng trắng bắt đầu bằng ký tự hoa kết thúc bằng số");
            string sinput = Console.ReadLine();
                if(check(sinput)==0)
                {
                    Console.WriteLine("Duyệt!");
                }else
                {
                    Console.WriteLine("Không duyệt!");
                }
        }
        static int check(string sinput)
        {
            if (Regex.IsMatch(sinput,"^[A-Z][^\\s]{0,18}\\d"))
                return 0;
            else
                return 1;
        }
    }
}
