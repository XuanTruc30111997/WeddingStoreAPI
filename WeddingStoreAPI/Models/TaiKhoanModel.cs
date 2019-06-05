using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;

namespace WeddingStoreAPI.Models
{
    public class TaiKhoanModel
    {
        [Key]
        public string ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string MaNV { get; set; }
        public NhanVienModel NhanVien { get; set; }
        
    }
}
