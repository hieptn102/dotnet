using System;

namespace oop2
{
    class Candidate
    {
        public string ma { set; get; }
        public string hoten { set; get; }
        public string ngaythang { set; get; }
        public double van { set; get; }
        public double toan { set; get; }
        public double anh { set; get; }
        public void nhapthongtin(int i){
        Console.WriteLine($"nhập mã sv{i+=1} ");
        this.ma = Console.ReadLine();

        Console.WriteLine("nhập họ tên sv ");
        this.hoten = Console.ReadLine();

        Console.WriteLine("nhập ngày sinh sv ");
        this.ngaythang = Console.ReadLine();

        Console.WriteLine("nhập điểm văn ");
        this.van =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm toán ");
        this.toan =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm anh ");
        this.anh =Convert.ToDouble(Console.ReadLine());

       }
       public double tongdiem(){
          double tong = 0 ;
          tong = this.van + this.toan + this.anh;
           return tong;
       }
    }
}