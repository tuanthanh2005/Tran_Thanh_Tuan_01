using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_Thanh_Tuan_01
{
    class NhanVienHD:NhanVien
    {
        private int doanhthu;


        public NhanVienHD() :base (){ }
        public NhanVienHD(int doanhthu,string maso,string hoten,int luongcung) : base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public int DoanhThu
        {
            set { doanhthu = value; }
            get { return doanhthu; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Doanh Thu: ");
            doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return (int) 0.05 * doanhthu;
        }

    }
}
