using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class KhachHangModel
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }

        public HoaDonModel HoaDon { get; set; }
        public DatLichModel DatLich { get; set; }
    }
}
