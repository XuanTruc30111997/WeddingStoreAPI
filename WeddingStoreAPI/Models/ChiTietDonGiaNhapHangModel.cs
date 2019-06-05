using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class ChiTietDonGiaNhapHangModel
    {
        public string MaDG { get; set; }
        public DonGiaNhapHangModel DonGiaNhapHang { get; set; }
        public string MaVL { get; set; }
        public VatLieuModel VatLieu { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
    }
}
