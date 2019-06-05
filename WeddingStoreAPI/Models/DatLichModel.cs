using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingStoreAPI.Models
{
    public class DatLichModel
    {
        [Key]
        public string MaDL { get; set; }
        public string MaKH { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgayCuoi { get; set; }
        public Nullable<System.DateTime> NgayTrangTri { get; set; }
        public Nullable<System.TimeSpan> ThoiGianTrangTri { get; set; }
        public Nullable<bool> TrangThaiDuyet { get; set; }

        public virtual KhachHangModel KhachHang { get; set; }
    }
}
