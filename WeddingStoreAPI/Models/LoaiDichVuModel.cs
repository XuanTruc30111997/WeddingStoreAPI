using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class LoaiDichVuModel
    {
        [Key]
        public string MaLoaiDV { get; set; }
        public string TenLoaiDV { get; set; }
        public IList<DichVuModel> DichVus { get; set; }
    }
}
