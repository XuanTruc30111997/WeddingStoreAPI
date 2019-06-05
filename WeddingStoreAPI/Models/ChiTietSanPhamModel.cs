using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class ChiTietSanPhamModel
    {
        public string MaSP { get; set; }
        public SanPhamModel SanPham { get; set; }
        public string MaVL { get; set; }
        public VatLieuModel VatLieu { get; set; }
        public int SoLuong { get; set; }
        public float GiaTien { get; set; }
    }
}
