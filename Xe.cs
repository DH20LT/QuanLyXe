using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Xe
    {
        string SoXe;
        public void setXe(string SoXe) { this.SoXe = SoXe;}
        public string getXe() { return SoXe;}
        string MauXe;
        public void setMauXe(string MauXe) { this.MauXe = MauXe;}
        public string getMauXe() { return MauXe;}
        string NuocSanXuat;
        public void setNuocSanXuat(string NuocSanXuat) { this.NuocSanXuat = NuocSanXuat;}
        public string getNuocSanXuat() { return NuocSanXuat;}
        string HangSanXuat;
        public void setHangSanXuat(string HangSanXuat) { this.HangSanXuat = HangSanXuat;}
        public string getHangSanXuat() { return HangSanXuat;}
        int NamSanXuat;
        public void setNamSanXuat(int NamSanXuat) { this.NamSanXuat = NamSanXuat;}
        public int getNamSanXuat() { return NamSanXuat;}
        string SoBanhXe;
        public void setSoBanhXe(string SoBanhXe) { this.SoBanhXe = SoBanhXe;}
        public string getSoBanhXe() { return SoBanhXe;}

        public Xe() // ()
        {
            this.SoXe = "";
            this.MauXe = "";
            this.NuocSanXuat = "";
            this.HangSanXuat = "";
            this.NamSanXuat = 0;
            this.SoBanhXe = "";
        }
        public Xe
(string SoXe, string MauXe, string NuocSanXuat, string HangSanXuat, int NamSanXuat, string SoBanhXe)
        { // (askjhdkhsakdnksan)
            this.SoXe = SoXe;
            this.MauXe = MauXe;
            this.NuocSanXuat = NuocSanXuat;
            this.HangSanXuat = HangSanXuat;
            this.SoBanhXe = SoBanhXe;
        }
        public virtual void NhapThongTin()
        {
            Console.WriteLine("Số Xe la: ");
            SoXe = Console.ReadLine();
            Console.WriteLine("Mẫu Xe la: ");
            MauXe = Console.ReadLine();
            Console.WriteLine("Nước Sản Xuất la: ");
            NuocSanXuat = Console.ReadLine();
            Console.WriteLine("Hãng Sản Xuất la: ");
            HangSanXuat = Console.ReadLine();
            Console.WriteLine("Số Bánh Xe la: ");
            SoBanhXe = Console.ReadLine();
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("SoXe la: " + SoXe);
            Console.WriteLine("MauXe la: " + MauXe);
            Console.WriteLine("NuocSanXuat la: " + NuocSanXuat);
            Console.WriteLine("HangSanXuat la: " + HangSanXuat);
            Console.WriteLine("SoBanhXe la: " + SoBanhXe);
        }
    }
}
