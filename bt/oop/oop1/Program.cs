using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Phanso p1 = new Phanso();
            Phanso p2 = new Phanso();
            Phanso p3 = new Phanso();
 
            Console.WriteLine("Nhap phan so 1");
            p1.NhapPhanso();
 
            Console.WriteLine("Nhap phan so 2");
            p2.NhapPhanso();
 
            p3 = p3.tong(p1, p2);
            Console.Write("tong 2 phan so la: ");
            p3.InPhanso();
            Console.WriteLine();
            p3 = p3.hieu(p1, p2);
            Console.Write("hieu 2 phan so la: ");
            p3.InPhanso();
            Console.WriteLine();
            p3 = p3.tich(p1, p2);
            Console.Write("tich 2 phan so la: ");
            p3.InPhanso();
            Console.WriteLine();
            p3 = p3.thuong(p1, p2);
            Console.Write("thuong 2 phan so la: ");
            p3.InPhanso();
 
 
            Console.ReadKey();
        }
    }
}
