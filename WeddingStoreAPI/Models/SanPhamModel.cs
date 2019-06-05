using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class SanPhamModel
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaTien { get; set; }
        public string DichVu { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte[] HinhMoTa { get; set; }

        public IList<ChiTietSanPhamModel> ChiTietSanPhams { get; set; }
        public IList<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }
    }
}
