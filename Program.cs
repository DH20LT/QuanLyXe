using System;
using System.Text;

namespace QuanLyXe
{
    class Program
    {
        static void UpdatePhanKhoi(){

        }
        static void Programming(Xe[] listVehicle)
        {
            int VongLap = 1;
            int iSoXe = 0;
            while (VongLap < 50)
            {
                Console.WriteLine("1. Tạo đối tượng Xe");
                Console.WriteLine("2. Tạo đối tượng XeOto");
                Console.WriteLine("3. Tạo đối tượng XeTai");
                Console.WriteLine("4. Tạo đối tượng XeMay");
                Console.WriteLine("5. Xuất Cả Danh Sách Xe");
                Console.WriteLine("6. Cập Nhật PhanKhoi XeMay");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("Chọn chức năng bạn muốn sử dụng..!");
                int ChucNang = int.Parse(Console.ReadLine());
                switch (ChucNang)
                {
                    case 0:// Thoát chương trình
                    {
                        Environment.Exit(0);
                        break;
                    }
                    case 1: // Tạo đối tượng xe
                        {
                            Console.Clear();
                            listVehicle[iSoXe] = new Xe();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 2: // Tạo đối tượng XeOto
                        {
                            Console.Clear();
                            listVehicle[iSoXe] = new XeOto();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 3: // Tạo đối tượng XeTai
                        {
                            Console.Clear();
                            listVehicle[iSoXe] = new XeTai();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 4: // Tạo đối tượng XeMay
                        {
                            Console.Clear();
                            listVehicle[iSoXe] = new XeMay();
                            listVehicle[iSoXe].NhapThongTin();
                            iSoXe++;
                            break;
                        }
                    case 5: //Hiện tất cả danh sách xe
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sách xe gồm: ");
                            for(int i = 0; i <= iSoXe ; i++)
                            {
                                listVehicle[i].XuatThongTin();
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 6: {//Cập nhật phân khối xe

                        break;
                    }
                    default:
                        Console.WriteLine("Làm gì có chức năng đó..!");
                        break;
                }
                VongLap++;
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Xe[] listVehicle = new Xe[20];
            Programming(listVehicle);
        }
    }
}
