using System;

namespace oop2
{
     class TestCandidate
    {
        static void Main(string[] args)
        {
            xuly aa = new xuly();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số sinh viên");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++){
                aa.nhaptt(i);

            }
            Console.WriteLine("Thí sinh có tổng điểm trên 1 là:");
            aa.tongdiem(aa.getStudent());
        }

    }   
}
