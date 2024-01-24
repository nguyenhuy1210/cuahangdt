using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT
{
    public class DienThoai
    {
        public string MaDienThoai { get; set; }
        public string TenDienThoai { get; set; }
        public string ThuongHieu { get; set; }

        public DienThoai(string maDienThoai, string tenDienThoai, string thuongHieu)
        {
            MaDienThoai = maDienThoai;
            TenDienThoai = tenDienThoai;
            ThuongHieu = thuongHieu;
        }
    }

    public class DienThoaiChiTiet : DienThoai
    {
        public string DungLuong { get; set; }
        public string MauSac { get; set; }
        public int SoLuong { get; set; }
        public double GiaTien { get; set; }
        public bool TrangThai { get; set; }

        public DienThoaiChiTiet(string maDienThoai, string tenDienThoai, string thuongHieu, string dungLuong, string mauSac, int soLuong, double giaTien, bool trangThai)
            ///// Gọi thêm contructor của class cha
            : base(maDienThoai, tenDienThoai, thuongHieu)
        {
            DungLuong = dungLuong;
            MauSac = mauSac;
            SoLuong = soLuong;
            GiaTien = giaTien;
            TrangThai = trangThai;
        }
        public void ThongTinDienThoai()
        {

        }
    }
}
