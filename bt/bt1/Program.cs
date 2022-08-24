using System;
namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên:");
            int sinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Số đã nhập là: {sinput}");
            if(sinput>0){
                Console.WriteLine($"Số {sinput} là số nguyên dương");
            }else
                Console.WriteLine($"Số {sinput} là số nguyên âm");
        }
    }
}