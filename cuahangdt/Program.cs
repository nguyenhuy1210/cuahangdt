using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuanLyDT
{
    internal class Program
    {
        static ArrayList DanhSachDienThoai = new ArrayList();
        static ArrayList DanhSachDienThoaiChiTiet = new ArrayList();


        ///List<DienThoai> danhSachDienThoai = new List<DienThoai>();
        ////List<DienThoaiChiTiet> danhSachDienThoaiChiTiet = new List<DienThoaiChiTiet>();
        ///
        static void Main()
        {

            DienThoai dt1 = new DienThoai("DT01", "iPhone 15", "Apple");
            DanhSachDienThoai.Add(dt1);
            DienThoaiChiTiet dtct1 = new DienThoaiChiTiet("DT001", "iPhone 13", "Apple", "128GB", "Blue", 10, 25000000, true);
            DanhSachDienThoaiChiTiet.Add(dtct1);

            DienThoai dt2 = new DienThoai("DT02", "Galaxy S24", "Samsung");
            DanhSachDienThoai.Add(dt2);
            DienThoaiChiTiet dtct2 = new DienThoaiChiTiet("DT002", "Galaxy S24", "Samsung", "256GB", "Black", 8, 23000000, true);
            DanhSachDienThoaiChiTiet.Add(dtct2);

            DienThoai dt3 = new DienThoai("DT03", "Rog phone 7", "Asus");
            DanhSachDienThoai.Add(dt3);
            DienThoaiChiTiet dtct3 = new DienThoaiChiTiet("DT003", "ROG Phone 7", "ASUS", "512GB", "White", 5, 20000000, false);
            DanhSachDienThoaiChiTiet.Add(dtct3);
            while (true)
            {
                Console.WriteLine("+-------------------");
                Console.WriteLine("QUan LY Cua Hnag Dien Thoai");
                Console.WriteLine("1.Them dien thoai");
                Console.WriteLine("2.them dien Thoai chi tiet");
                Console.WriteLine("3.Tim dien Thoai ");
                Console.WriteLine("4.Dang/Ngung khinh doanh");
                Console.WriteLine("5.Thoat");

                Console.Write("Moi chon chuc nang ban muon: ");
                int so = int.Parse(Console.ReadLine());

                switch (so)
                {
                    case 1:
                        Console.WriteLine("Ban da chon chuc nang them dien thoai");
                        ThemDienThoai();
                        break;
                    case 2:
                        Console.WriteLine("Ban da chon chuc nang them dien thoai");
                        ThemDienThoaiChiTiet();
                        break;
                    case 3:
                        Console.WriteLine("Ban da chon chuc nang them dien thoai");
                        TimDienThoai();
                        break;
                    case 4:
                        Console.WriteLine("Ban da chon chuc nang them dien thoai");
                        DangNgungKinhDoanh();
                        break;
                    case 5:
                        Console.WriteLine("Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Moi ban chon lai.");
                        break;
                }
            }

        }
        static void ThemDienThoai()
        {
            Console.Write("Moi nhap Ma Dien Thoai");
            string maDienThoai = Console.ReadLine();

            Console.Write("Nhap ten dien thoai: ");
            string tenDienThoai = Console.ReadLine();

            Console.Write("Nhap thuong hieu: ");
            string thuongHieu = Console.ReadLine();

            DienThoai dt = new DienThoai(maDienThoai, tenDienThoai, thuongHieu);
            DanhSachDienThoai.Add(dt);

        }
        static void ThemDienThoaiChiTiet()
        {
            Console.Write("Moi nhap Ma Dien Thoai");
            string maDienThoai = Console.ReadLine();
            foreach (DienThoai dt in DanhSachDienThoai)
            {
                if (dt.MaDienThoai == maDienThoai)
                {
                    Console.Write("Nhap dung luong: ");
                    string dungLuong = Console.ReadLine();

                    Console.Write("Nhap mau sac: ");
                    string mauSac = Console.ReadLine();

                    Console.Write("Nhap so luong: ");
                    int soLuong = int.Parse(Console.ReadLine());

                    Console.Write("Nhap gia tien: ");
                    double giaTien = double.Parse(Console.ReadLine());

                    Console.Write("Nhap trang thai : ");
                    bool trangThai = bool.Parse(Console.ReadLine());

                    DienThoaiChiTiet dtct = new DienThoaiChiTiet(maDienThoai, dt.TenDienThoai, dt.ThuongHieu, dungLuong, mauSac, soLuong, giaTien, trangThai);
                    DanhSachDienThoaiChiTiet.Add(dtct);

                    return;
                }
            }
            Console.WriteLine("Ma dien thoai khong ton tai trong danh sach.");
        }
        static void TimDienThoai()
        {
            Console.Write("Nhap ma dien thoai can tim: ");
            string maDienThoai = Console.ReadLine();

            foreach (DienThoaiChiTiet dtct in DanhSachDienThoaiChiTiet)
            {
                if (dtct.MaDienThoai == maDienThoai)
                {
                    ///string trangThai;
                    //if (dtct.TrangThai)
                    //{
                    // trangThai = "Dang kinh doanh";
                    //}
                    // else
                    //{
                    //trangThai = "Ngung kinh doanh";
                    //}
                    Console.WriteLine($"1.Ma Dien Thoai: {dtct.MaDienThoai}, " +
                        $"2.Ten Dien Thoai: {dtct.TenDienThoai}, " +
                        $"3.Thuong Hieu: {dtct.ThuongHieu}, " +
                        $"4.Dung Luong: {dtct.DungLuong}, " +
                        $"5.Mau Sac: {dtct.MauSac}, " +
                        $"6.So Luong: {dtct.SoLuong}, " +
                        $"7.Gia Tien: {dtct.GiaTien}, " +
                        $"8.Trang Thai: {(dtct.TrangThai ? "Dang kinh doanh" : "Ngung kinh doanh")}");
                    ///{trangThai}
                }
            }
        }

        static void DangNgungKinhDoanh()
        {
            Console.Write("Nhap ma dien thoai can sua: ");
            string maDienThoai = Console.ReadLine();

            foreach (DienThoaiChiTiet dtct in DanhSachDienThoaiChiTiet)
            {
                if (dtct.MaDienThoai == maDienThoai)
                {
                    dtct.TrangThai = !dtct.TrangThai;
                    Console.WriteLine("Da cap nhat trang thai kinh doanh.");
                    return;
                }
            }
            Console.WriteLine("Ma dien thoai khong ton tai trong danh sach.");
        }
    }
}
