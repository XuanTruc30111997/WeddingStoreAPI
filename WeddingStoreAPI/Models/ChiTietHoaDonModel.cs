using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class ChiTietHoaDonModel
    {
        public string MaHD { get; set; }
        public HoaDonModel HoaDon { get; set; }
        public string MaSP { get; set; }
        public SanPhamModel SanPham { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
    }
}
