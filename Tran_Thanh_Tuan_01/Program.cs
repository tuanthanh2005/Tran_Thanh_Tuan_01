using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thanh_Tuan_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon;
            do { 
            Console.WriteLine("1.Nhap Danh Sach Nhan Vien");
            Console.WriteLine("2.Xuat Danh Sach Nhan Vien");
            Console.WriteLine("3.Tinh Tong Luong Nhan Vien");
            Console.WriteLine("4.Tinh Luong Trung Binh Nhan Vien");
            Console.WriteLine("5.Thoat");
       
           
                Console.WriteLine("Chon Chuc Nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.Nhap();
                        break;
                    case 2:
                        ql.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Sau Khi Tinh Tong Luong Duoc", ql.TinhTongLuong());
                        break;
                    case 4:
                        Console.WriteLine("Sau Khi Tinh Tong Luong Duoc", ql.TinhTrungBinh());
                        break;
                    case 5:
                        Console.WriteLine("Xin Cam On");
                        
                        break;
                    default:
                        Console.WriteLine("Xin Vui Long Chon Lai !!! ");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 5);

        }
    }
}
        

