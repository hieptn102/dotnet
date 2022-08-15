using System;

namespace bt9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương nhở hơn 20");
            int n = Convert.ToInt32(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            if(n<0 || n>20){
                Console.WriteLine("Số không hợp lệ!");
            }else if(n==0){
                Console.WriteLine("F0=0");
            }
            else if(n==1){
                Console.WriteLine("F1=1");
            }
            else{
                for(int i=2;i<=n;i++)
                {   
                    f0=f1;
                    f1=fn;
                    fn=f0+f1;
                }
                Console.WriteLine($"F{n}={fn}");
            }
        }
    }
}
