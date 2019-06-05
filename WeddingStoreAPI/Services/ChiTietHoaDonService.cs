using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class ChiTietHoaDonService : IDataService<ChiTietHoaDonModel>
    {
        private readonly WeddingStoreContext _context;
        public ChiTietHoaDonService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietHoaDonModel> GetData()
        {
            return _context.ChiTietHoaDon.ToList();
        }

        public void InsertData(ChiTietHoaDonModel obj)
        {
            _context.ChiTietHoaDon.Add(obj);
            _context.SaveChanges();
        }

        public void UpdateData(ChiTietHoaDonModel obj)
        {
            ChiTietHoaDonModel myUpdate = _context.ChiTietHoaDon.FirstOrDefault(ct => ct.MaHD == obj.MaHD && ct.MaSP == obj.MaSP);
            if (myUpdate != null)
            {
                myUpdate.SoLuong = obj.SoLuong;
                myUpdate.ThanhTien = obj.ThanhTien;

                _context.ChiTietHoaDon.Update(myUpdate);
                _context.SaveChanges();
            }
        }

        public void MyDeleteData(ChiTietHoaDonModel obj)
        {
            ChiTietHoaDonModel myDelete = _context.ChiTietHoaDon.FirstOrDefault(ct => ct.MaHD == obj.MaHD && ct.MaSP == obj.MaSP);
            if (myDelete != null)
            {
                _context.ChiTietHoaDon.Remove(myDelete);
                _context.SaveChanges();
            }
        }
    }
}
