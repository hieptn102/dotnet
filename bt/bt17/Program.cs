using System;

namespace bt17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi");
            string sinput = Console.ReadLine();
            Console.WriteLine("Nhập vào 1 kí tự cần đối chiếu");
            string k = Console.ReadLine();
            if(k.Length == 1)
            {
                if(sinput.IndexOf(k)!=-1)
                {
                    Console.WriteLine($"Kí tự ở vị trí {sinput.IndexOf(k)} trong chuỗi");
                }else
                {
                    Console.WriteLine("Không có kí tự trong chuỗi!");
                }
            }else
            {
                Console.WriteLine("Vui lòng chỉ nhập 1 kí tự!");
            }
        }
    }
}
