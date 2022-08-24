using System;

namespace bt8
{
    class Program
    {
            
             static int isPrimeNumber(int n)
            {
                // so nguyen n < 2 khong phai la so nguyen to
                if (n < 2)
                {
                    return 0;
                }
                // check so nguyen to khi n >= 2
                int i;
                int squareRoot = (int) Math.Sqrt(n);
                for (i = 2; i <= squareRoot; i++)
                {
                    if (n % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
            static void Main(string[] args)
            {
                int i, n;
                Console.Write("Nhap so nguyen n = ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tat ca cac so nguyen to nho hon {0} la: \n", n);
                for (i = 2; i < n; i++)
                {
                    if (isPrimeNumber(i) == 1)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                ;
            }
        
    }
}
