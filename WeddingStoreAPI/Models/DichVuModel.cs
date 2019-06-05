using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class DichVuModel
    {
        [Key]
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string LoaiDV { get; set; }
        public string ThongTinMoTa { get; set; }
        public LoaiDichVuModel LoaiDichVu { get; set; }
    }
}
