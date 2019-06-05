using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class DonGiaNhapHangModel
    {
        [Key]
        public string MaDG { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongTien { get; set; }

        public string MaNCC { get; set; }
        public NhaCungCapModel NhaCungCap { get; set; }

        public IList<ChiTietDonGiaNhapHangModel> ChiTietDonGiaNhapHangs { get; set; }
    }
}
