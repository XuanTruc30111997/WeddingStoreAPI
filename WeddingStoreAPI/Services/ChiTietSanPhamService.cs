using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class ChiTietSanPhamService : IDataService<ChiTietSanPhamModel>
    {
        private readonly WeddingStoreContext _context;
        public ChiTietSanPhamService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSanPhamModel> GetData()
        {
            return _context.ChiTietSanPham.ToList();
        }

        public void InsertData(ChiTietSanPhamModel obj)
        {
            _context.ChiTietSanPham.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(ChiTietSanPhamModel obj)
        {
            var myDelete = _context.ChiTietSanPham.FirstOrDefault(ct => ct.MaSP == obj.MaSP && ct.MaVL == obj.MaVL);
            if (myDelete != null)
            {
                _context.ChiTietSanPham.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(ChiTietSanPhamModel obj)
        {
            var myUpdate = _context.ChiTietSanPham.FirstOrDefault(ct => ct.MaSP == obj.MaSP && ct.MaVL == obj.MaVL);
            if (myUpdate != null)
            {
                myUpdate.SoLuong = obj.SoLuong;
                myUpdate.GiaTien = obj.GiaTien;

                _context.ChiTietSanPham.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
