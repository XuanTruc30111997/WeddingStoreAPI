using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class ChiTietDonGiaNhapHangService : IDataService<ChiTietDonGiaNhapHangModel>
    {
        private readonly WeddingStoreContext _context;
        public ChiTietDonGiaNhapHangService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietDonGiaNhapHangModel> GetData()
        {
            return _context.ChiTietDonGiaNhapHang.ToList();
        }

        public void InsertData(ChiTietDonGiaNhapHangModel obj)
        {
            _context.ChiTietDonGiaNhapHang.Add(obj);
            _context.SaveChanges();
        }

        public void UpdateData(ChiTietDonGiaNhapHangModel obj)
        {
            ChiTietDonGiaNhapHangModel myUpdate = _context.ChiTietDonGiaNhapHang.FirstOrDefault(ct => ct.MaDG == obj.MaDG && ct.MaVL == obj.MaVL);
            if (myUpdate != null)
            {
                myUpdate.SoLuong = obj.SoLuong;
                myUpdate.ThanhTien = obj.ThanhTien;

                _context.ChiTietDonGiaNhapHang.Update(myUpdate);
                _context.SaveChanges();
            }
        }

        public void MyDeleteData(ChiTietDonGiaNhapHangModel obj)
        {
            ChiTietDonGiaNhapHangModel myDelete = _context.ChiTietDonGiaNhapHang.FirstOrDefault(ct => ct.MaDG == obj.MaDG && ct.MaVL == obj.MaVL);
            if (myDelete != null)
            {
                _context.ChiTietDonGiaNhapHang.Remove(myDelete);
                _context.SaveChanges();
            }
        }
    }
}
