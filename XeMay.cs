using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeMay : Xe
    {
        //Properties
        int PhanKhoi;
        public int getPhanKhoi(){return PhanKhoi;}
        public void setPhanKhoi(int PhanKhoi){this.PhanKhoi = PhanKhoi;}

        // Constructor
        public XeMay():base()
        {
            this.PhanKhoi = 0;
        }
        public XeMay
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe,
            int PhanKhoi)
            : base(SoXe, MauXe, NuocSanXuat, HangSanXuat, NamSanXuat, SoBanhXe)
        {
            this.PhanKhoi = PhanKhoi;
        }

        // Methods
        public override void NhapThongTin()
        {
            Console.WriteLine("Nhập Thông Tin Xe Máy");
            base.NhapThongTin();
            Console.WriteLine("PhanKhoi la: ");
            PhanKhoi = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("PhanKhoi la: " + PhanKhoi);
        }
        public void CapNhatPhanKhoi()
        {
            Console.WriteLine("Phân Khối Cũ là: " + this.PhanKhoi);
            Console.WriteLine("Nhập PhanKhoi moi: ");
            this.PhanKhoi = int.Parse(Console.ReadLine());
        }
        public void CapNhatPhanKhoi(int PhanKhoi)
        {
            this.PhanKhoi = PhanKhoi;
        }
    }
}
