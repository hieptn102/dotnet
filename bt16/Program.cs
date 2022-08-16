using System;

namespace bt16
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
            if(k.Length==1)
            {
                if(sinput.Contains(k))
                {
                    Console.WriteLine("Có!");
                }else
                {
                    Console.WriteLine("Không!");
                }
            }else
            {
                Console.WriteLine("Vui lòng chỉ nhập 1 kí tự!");
            }
            
        }
    }
}
