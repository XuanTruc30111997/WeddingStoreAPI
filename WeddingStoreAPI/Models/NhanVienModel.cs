using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WeddingStoreAPI.Models;

namespace WeddingStoreAPI.Models
{
    public class NhanVienModel
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public byte[] Avatar { get; set; }
        public float Luong { get; set; }

        public IList<PhanCongModel> PhanCongs { get; set; }
        public TaiKhoanModel TaiKhoan { get; set; }
    }
}
