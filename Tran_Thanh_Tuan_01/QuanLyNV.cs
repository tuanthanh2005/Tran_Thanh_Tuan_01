using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thanh_Tuan_01
{
    class QuanLyNV
    {
        private List<NhanVien> dsnv;
        public QuanLyNV()
        {
            dsnv = new List<NhanVien>();
        }
        public void Nhap()
        {
            string tieptuc = "y";
            int luaChon;
            NhanVien nv;
            do
            {
                Console.WriteLine("Chon 1.Bien Che /  2.Hop Dong");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsnv.Add(nv);
                break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsnv.Add(nv);
                        break;

                    default:
                        Console.WriteLine("Ban Nhap Sai Vui Long Nhap Lai 1.Bien Che/ 2.Hop Dong");
                        break;
                }
                Console.WriteLine("Ban Co Muon Tiep Tuc Vui Long Chon y/n");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower()=="y");

        }
        public void Xuat()
        {
            Console.WriteLine($"{"Ma So",-10 }  {"Ho Ten",10} {"LuongCung", 10}  {"Luong ", 20:#,##0}");
            foreach(NhanVien x in dsnv)
            {
                Console.WriteLine($"{x.MaSo ,-10 }  {x.Hoten,10} {x.LuongCung, 10} {x.TinhLuong(),20}");
            }
            
        }
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach(NhanVien n in dsnv)
            {
                sum += n.TinhLuong();
            }return sum;
        }
        public double TinhTrungBinh()
        {
            int cout = dsnv.Count();
            return TinhTongLuong() / cout;
            
         
        }
    }
}
