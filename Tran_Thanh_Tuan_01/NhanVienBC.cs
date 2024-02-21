using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thanh_Tuan_01
{
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;


        public NhanVienBC() : base() { }

        public NhanVienBC(string mucxeploai, string maso, string hoten, int luongcung) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Muc Xep Loai ");
            mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double tl=0;
            if (mucxeploai == "A")
            {              
                tl = 1.8 * LuongCung;
                return (int)tl;
            }
            else if (mucxeploai == "B")
            {
      
                tl = 1.2 * LuongCung;
                return (int)tl;
            }
            else if (mucxeploai =="C")
            {
                tl = 0.8 * LuongCung;
                return (int)tl;
            }
            return (int)tl;
        } 
    }
}
