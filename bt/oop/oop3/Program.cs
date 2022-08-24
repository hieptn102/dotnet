using System;

namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            mstudent aa = new mstudent();

            while(true){
                Console.WriteLine("Chọn chức năng: ");
            Console.WriteLine(@"            /******************MENU******************/
            1. Add student.
            2. Edit student by id.
            3. Delete student by id.
            4. Sort student by gpa.
            5. Sort student by name.
            6. Show student.
            0. Exit.
            /****************************************/");
            int cdigit = Convert.ToInt32(Console.ReadLine());
            switch (cdigit)
            {
                case 0:
                    Console.Write("Bạn đã thoát chương trình!!!\n");
                    return;
                case 1:
                    Console.WriteLine("\n1. Them sinh vien.");
                    aa.add();
                    Console.WriteLine("\nThem sinh vien thanh cong!");
                    break;
                case 2:
                    
                    if(aa.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        aa.Update(id);
                    }else
                    {

                    }
                    break;
                case 3:
                    if (aa.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n3. Xoa sinh vien.");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (aa.DeleteById(id))
                        {
                            Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                        }
                    }else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 4:
                    if (aa.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Sap xep sinh vien theo diem (GPA).");
                            aa.SortByGPA();
                            aa.Show(aa.getStudents());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                    break;
                case 5:
                    if (aa.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                            aa.SortByName();
                            aa.Show(aa.getStudents());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                case 6:
                    if(aa.SoLuongSinhVien() > 0)
                    {
                        aa.Show(aa.getStudents());
                    }else
                    {
                        Console.WriteLine("Danh sách trống!");
                    }
                    break;
                default:
                    Console.Write("Bạn đã thoát chương trình!!!\n");
                    break;
            }  
            }
        }
    }
}
