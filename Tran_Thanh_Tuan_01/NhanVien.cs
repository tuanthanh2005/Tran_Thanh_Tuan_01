using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thanh_Tuan_01
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;


        public NhanVien() { }
        public NhanVien(string maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
        public string MaSo
        {
            set { maso = value; }
            get { return maso; }
        }
        public string Hoten
        {
            set { hoten = value; }
            get { return hoten; }
        }
        public int LuongCung
        {
            set { luongcung = value; }
            get { return luongcung; }
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma so: ");
            this.maso = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: ");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap luong cung");
            this.luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return 0;
        }
    }
}
