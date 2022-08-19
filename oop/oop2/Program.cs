using System;

namespace oop2
{
    class ProTestCandidate
    {
        static void Main(string[] args)
        {
            Candidate sv = new Candidate();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số sinh viên");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] m = new string[n];
            string[] ht = new string[n];
            string[] ns = new string[n];
            double[] t = new double[n];
            double[] v = new double[n];
            double[] a = new double[n];
            double[] tcm = new double[n];
            for(int i=0;i<n;i++){
                sv.nhapthongtin(i);
                m[i] = sv.ma;
                ht[i] = sv.hoten;
                ns[i] = sv.ngaythang;
                t[i] = sv.toan;
                v[i] = sv.van;
                a[i] = sv.anh;
                tcm[i] = sv.tongdiem();
            }
            double sum = 0;
            Console.WriteLine($"thông tin sinh viên có tổng điểm trên 1 là :");
            for(int j=0;j<n;j++){
                 sum = tcm[j];
                if(sum > 1){
                
                Console.Write($"sinh viên thứ {j+=1}");
                Console.Write($" mã sinh viên = ");
                Console.Write($" {m[j]} ");
                Console.Write($" tên sinh viên :");
                Console.Write(t[j]);
                }
            }
        }
    }
}
