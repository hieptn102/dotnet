using System;
using System.Collections.Generic;
namespace oop2
{ 
    class Candidate{
       public string ma { set; get; }
       public string hoten { set; get; }
       public string ngaythang { set; get; }
       public double van { set; get; }
       public double toan { set; get; }
       public double anh { set; get; }
    }
    class xuly{
        private List<Candidate> students = null;
 
        public xuly() {
            students = new List<Candidate>();
        }
       public void nhaptt(int i){
        Candidate st = new Candidate();
        Console.WriteLine($"nhập mã sv{i+=1} ");
        st.ma = Console.ReadLine();

        Console.WriteLine("nhập họ tên sv ");
        st.hoten = Console.ReadLine();

        Console.WriteLine("nhập ngày sinh sv ");
        st.ngaythang = Console.ReadLine();

        Console.WriteLine("nhập điểm văn ");
        st.van =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm toán ");
        st.toan =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhập điểm anh ");
        st.anh =Convert.ToDouble(Console.ReadLine());
        students.Add(st);

    }
        public void tongdiem(List<Candidate> student){
            double tong = 0;
            Console.WriteLine("{0, -5} {1, -20} {2, -5}",
                  "Ma", "Name", "Ngaysinh");
            foreach (Candidate sv in student)
            {
               tong = sv.van + sv.anh + sv.toan;
               if(tong>0){
                Console.WriteLine("{0, -5} {1, -20} {2, -5}",
                sv.ma, sv.hoten, sv.ngaythang);
               }
            }

       }
      public List<Candidate> getStudent()
        {
            return students;
        }

    }
}