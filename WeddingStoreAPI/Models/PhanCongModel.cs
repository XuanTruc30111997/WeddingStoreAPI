using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class PhanCongModel
    {
        [Key]
        public string MaNV { get; set; }
        public string MaHD { get; set; }
        public DateTime Ngay { get; set; }
        public Nullable<TimeSpan> ThoiGianDen { get; set; }
        public Nullable<TimeSpan> ThoiGianDi { get; set; }
        public virtual NhanVienModel NhanVien { get; set; }
        public virtual HoaDonModel HoaDon { get; set; }
    }
}
