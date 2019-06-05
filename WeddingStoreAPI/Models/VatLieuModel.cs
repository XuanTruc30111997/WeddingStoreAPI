using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class VatLieuModel
    {
        [Key]
        public string MaVL { get; set; }
        public string TenVL { get; set; }
        public int SoLuongTon { get; set; }
        public string DonVi { get; set; }
        public float GiaTien { get; set; }
        public byte[] AnhMoTa { get; set; }
        public bool IsNhap { get; set; }

        public IList<PhatSinhModel> PhatSinhs { get; set; }
        public IList<ChiTietDonGiaNhapHangModel> ChiTietDonGiaNhaphangs { get; set; }
        public IList<ChiTietSanPhamModel> ChiTietSanPhams { get; set; }
    }
}
