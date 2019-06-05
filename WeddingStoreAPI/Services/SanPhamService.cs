using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class SanPhamService : IDataService<SanPhamModel>
    {
        private readonly WeddingStoreContext _context;
        public SanPhamService(WeddingStoreContext context)
        {
            _context = context;
        }
        public void DeleteData(string id)
        {
            var myDelete = _context.SanPham.Find(id);
            if(myDelete!=null)
            {
                _context.SanPham.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<SanPhamModel> GetData()
        {
            return _context.SanPham.ToList();
        }

        public void InsertData(SanPhamModel obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(SanPhamModel obj)
        {
            var myDelete = _context.SanPham.Find(obj.MaSP);
            if (myDelete != null)
            {
                _context.SanPham.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(SanPhamModel obj)
        {
            var myUpdate = _context.SanPham.Find(obj.MaSP);
            if (myUpdate != null)
            {
                myUpdate.TenSP = obj.TenSP;
                myUpdate.HinhMoTa = obj.HinhMoTa;
                myUpdate.GiaTien = obj.GiaTien;
                myUpdate.DichVu = obj.DichVu;
                myUpdate.CreatedDate = obj.CreatedDate;
                myUpdate.UpdatedDate = obj.UpdatedDate;
                
                _context.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
