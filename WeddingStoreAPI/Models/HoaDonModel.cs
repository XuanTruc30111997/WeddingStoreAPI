using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class HoaDonModel
    {
        [Key]
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public KhachHangModel KhachHang { get; set; }
        public DateTime NgayLap { get; set; }
        //public string MaMau { get; set; }
        public DateTime NgayTrangTri { get; set; }
        public DateTime NgayThaoDo { get; set; }
        public float TongTien { get; set; }
        public int TinhTrang { get; set; }

        public IList<PhatSinhModel> PhatSinhs { get; set; }
        public IList<PhanCongModel> PhanCongs { get; set; }
        public IList<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }
    }
}
