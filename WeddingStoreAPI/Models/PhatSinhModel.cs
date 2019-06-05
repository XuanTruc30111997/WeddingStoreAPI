using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeddingStoreAPI.Models
{
    public class PhatSinhModel
    {
        public string MaHD { get; set; }
        public HoaDonModel HoaDon { get; set; }
        public string MaVL { get; set; }
        public VatLieuModel VatLieu { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }

        public PhatSinhModel(string maHD,string maVL,int soLuong,float thanhTien)
        {
            MaHD = maHD;
            MaVL = maVL;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }
        //public PhatSinhModel()
        //{

        //}
    }
}
