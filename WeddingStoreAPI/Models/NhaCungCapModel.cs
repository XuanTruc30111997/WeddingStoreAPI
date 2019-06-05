using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class NhaCungCapModel
    {
        [Key]
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }

        public DonGiaNhapHangModel DonGiaNhapHang { get; set; }
    }
}
